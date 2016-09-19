using System;

namespace Lab06
{
    class GoTooFar
    {
        static void Main(string[] args)
        {
int[] arr = {111,222,333,444,555};

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(arr[i] + ", ");
                }
            }
            //try should IMMEDIATELY be followed by eiter CATCH -or- FINALLY.
            //"throw" could be anywhere even without TRY block. But to catch that throw, u need a try-catch block
            //"Exception" is parent of "SystemException"(CLR ex) & "ApplicationException"(usr defined ex). These 3 r comonly used classes.
            //Compile-time err are NOT called exceptios. Only runtime(execution time) err r called "exceptions"=Exceptional-Behaviours.
            //If we don't use "catch" to "handle" ex, then it's "unhandled ex"
            //Robust prog is "fault-tolerant" that handles ex well rather than just closing coz of unhandled ex.
            //gen rule: if probability of ex if <30% then handle ex, otherwise write code to check input etc so ex doesn't occur in first place.
            //
            catch (IndexOutOfRangeException ex)//"ex" is optional
            {
                //Console.WriteLine(ex.ToString()); //generates same msg if ex was unhandled, except that word "Unhandled" is not there & that in unhandled case prog stops. While here it continues.
                //ToString uses .Message() & .GetType() to construct the returned string.
                //Console.WriteLine(ex.Message);  //display ONLY the Messgae part of the whole ToString() output.
                //Console.WriteLine(ex.GetType().Name); //displays sub-class of ex
                Console.WriteLine("\nNow you’ve gone too far.");
            }

            finally
            { }
            //"finally" block exe even if there's an "unhandled/uncaught" ex or even if try block has some statement that closes the prog e.g. see below. Finally is used frequently with file input and output(IOException) to ensure that open files are closed. Otherwise u might run out of "handles"!!
            //Environment.Exit(0);. //Will exit the prog. "0" arg or another int-arg is passed to system.
            //can exit "catch" e break; or return;

            //Can skip a catch-block & use just 'try-finally" pairs. The finally block is used to release resources that other applications might be waiting for, such as data-base connections, or close open files.


            //"Call Stack" is OS remembring method. 'A' that called method 'B' so it cud return to the calling met.A aft met.B finishes. If met.B throws ex, c# looks for "catch" in met.B, if cannot find any then it sends ex to met.A w can catch it (must have try-block thou). If still no catching, then prog is terminated bcoz of "unhandles/uncatght" ex. ---- Even if ex was "caught" in a method, u can re-throw it e "throw;" & let calling class do sth about it.

            //like ex.Message we cud use Console.WriteLine(ex.StackTrace); to see call-stack of methods one of w threw ex.

            //page-518: Previous recommendation was to make ur own child-class ex from ApplicationException, but now recommend to use Exception as parent (which takes string as param to it's constructor) & call constructor of Exception with a customized "string"-msg as arg.
            //e.g.



        // class NegativeBalanceException : Exception
        //{
        //    private static string msg = "Bank balance is negative. ";
        //    public NegativeBalanceException() : base(msg)  //custom msg will appear when e.Message
        //    {
        //    }
        //}


        //or we can customize .Message prop of Exception as follows: p-522

        /*throw(new Exception("This came from method C"));  //this is customizing the .Message of Exception class*/



    }
}
}
