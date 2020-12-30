namespace chainResponsability
{
    public class Cachorro: AbstractHandler
    {
        public override object Handler(object request)
        {
            if((string)request == "bife" )
                return $"Eu sou cachorro e vou comer {request}";

            return base.Handler(request);
        }
    }
}