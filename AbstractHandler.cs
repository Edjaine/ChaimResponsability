namespace chainResponsability
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
        public virtual object Handler(object request) {
            if (_nextHandler != null)
                return _nextHandler.Handler(request);

             return null;    
        }
    }
}