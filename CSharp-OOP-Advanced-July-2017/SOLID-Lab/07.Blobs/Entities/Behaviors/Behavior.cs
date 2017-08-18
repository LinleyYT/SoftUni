using _02.Blobs.Interfaces;

namespace _02.Blobs.Entities.Behaviors
{
    public abstract class Behavior : IBehavior
    {
        protected Behavior()
        {
            this.ToDelayRecurrentEffect = true;
        }

        public bool IsTriggered { get; set; }

        public bool ToDelayRecurrentEffect { get; set; }

        public abstract void Trigger(IBlob source);

        public abstract void ApplyPostTriggerEffect(IBlob source);

        public abstract void ApplyRecurrentEffect(IBlob source);
    }
}