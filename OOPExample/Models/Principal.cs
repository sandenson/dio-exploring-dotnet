namespace OOPExample.Models
{
    public class Principal : Teacher
    {
        public Principal(string name) : base(name)
        {
        }

        // public override void IntroduceSelf() // not allowed
        // {
        //     base.IntroduceSelf();
        // }
    }
}