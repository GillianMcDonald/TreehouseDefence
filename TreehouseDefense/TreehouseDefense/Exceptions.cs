//C# has built in excpetions but they aren't very informative.  we can set our own exceptions in order to track where errors are coming from
//just like our classes that can extend from one another any Exception class will extend from System.Exception and should have Exception in the name
//the System.Exception can take messages so we can add messages to our exceptions to help us track them.  we jsut have to referense teh base message

namespace TreehouseDefense
{
    class TreehouseDefenseException : System.Exception
    {
        public TreehouseDefenseException()
        {
        }

        public TreehouseDefenseException(string message) : base(message)
        {
        }
    }

    class OutOfBoundsException : TreehouseDefenseException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}