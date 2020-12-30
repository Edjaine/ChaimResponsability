namespace chainResponsability
{
    public class Esquilo: AbstractHandler
    {
        public override object Handler(object request)
        {
            if((string)request == "nut" )
                return $"Eu sou esquilo e vou comer {request}";

            return base.Handler(request);
        }
    }
}