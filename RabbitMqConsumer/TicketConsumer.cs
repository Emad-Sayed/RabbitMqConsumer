using MassTransit;
using RabbitMQ.Model;
using System;
using System.Threading.Tasks;

namespace RabbitMqConsumer
{
    //Dont Forget the model name space should be the same in publisher and cosnumer
    public class TicketConsumer : IConsumer<Ticket>
    {
        public async Task Consume(ConsumeContext<Ticket> context)
        {
            var data = context.Message;
            //Validate the Ticket Data
            //Store to Database
            //Notify the user via Email / SMS
        }
    }
}