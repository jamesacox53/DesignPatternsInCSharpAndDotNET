using System.Collections.Generic;

namespace Section17Mediator
{
    public class Participant
    {
        public int Value { get; set; }
        private Mediator mediator;

        public Participant(Mediator mediator)
        {
            this.mediator = mediator;
            mediator.AddParticipant(this);
        }

        public void Say(int n)
        {
            mediator.Broadcast(this, n);
        }

        public void RaiseValue(int n)
        {
            Value += n;
        }
    }

    public class Mediator
    {
        List<Participant> participants = new List<Participant>();

        public void AddParticipant(Participant participant)
        {
            participants.Add(participant);
        }

        public void Broadcast(Participant participant, int n)
        {
            foreach (Participant p in participants)
            {
                if (ReferenceEquals(p, participant)) continue;

                p.RaiseValue(n);
            }
        }
    }
}
