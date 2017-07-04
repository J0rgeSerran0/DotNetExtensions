namespace DotNetExtensions
{

    using System;
    using System.Text;

    public static class ExceptionExtensions 
    {

        public static StringBuilder GetMessagesFromInnerExceptions(this Exception ex)
        {
            var stringBuilder = new StringBuilder();
            var globalPattern = ex.GetType().ToString() + " ".PadLeft(1);

            return ex.InnerException == null ? stringBuilder.Append(globalPattern + ex.Message) : stringBuilder.Append(globalPattern + ex.Message + Environment.NewLine + ex.InnerException.GetMessagesFromInnerExceptions());
        }

        private static T GetObject<T>(string message)
        {
            return (T)Activator.CreateInstance(typeof(T), message);
        }

        public static T ToException<T>(this object @object, string message = "") where T : Exception, new()
        {
            var exception = new T();

            if (!String.IsNullOrEmpty(message))
            {
                exception = GetObject<T>(message);
            }

            return exception;
        }

        public static T ThrowIfNull<T>(this T @object, string paramName = "") where T : class
        {
            if (@object == null)
            {
                if (!String.IsNullOrEmpty(paramName))
                {
                    throw new ArgumentNullException(paramName);
                }

                throw new ArgumentNullException();
            }

            return @object;
        }

    }

}