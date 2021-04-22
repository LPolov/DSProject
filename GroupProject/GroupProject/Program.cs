namespace GroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*WorkFlow object implements Facade pattern.
             *It is used to show work flow of college 
             *and hide implementation from the user.
             */
            WorkFlow flow = new WorkFlow("Humber");
            flow.demostrateWorkFlow();
        }
    }
}
