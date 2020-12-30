namespace chainResponsability
{
    public class Gato : AbstractHandler
    {
        public override object Handler(object request)
        {
            if((string)request == "peixe" )
                return $"Eu sou gato e vou comer {request}";

            return base.Handler(request);
        }
    }
}