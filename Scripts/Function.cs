using Model;

namespace Function
{
    public class Handler
    {
        public AliceResponse FunctionHandler(AliceRequest request)
        {
            var response = new AliceResponse();
            response.response.text = request.request.command;
            response.statusCode = 200;
            response.session = request.session;
            return response;
        }
    }
}