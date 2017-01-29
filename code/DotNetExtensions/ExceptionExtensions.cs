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

    }

}