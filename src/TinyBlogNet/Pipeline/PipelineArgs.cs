using Microsoft.Owin;

namespace TinyBlogNet.Pipeline
{
    public class PipelineArgs
    {
        public PipelineArgs(IOwinContext ctx)
        {
            Context = ctx;
        }

        public string Layout { get; set; }
        public IOwinContext Context { get; private set; }
        public bool IsAborted { get; private set; }

        public void Abort()
        {
            IsAborted = true;
        }
    }
}