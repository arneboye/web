using System;
using ServiceStack;

namespace MyApp.ServiceModel
{
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }

    [Route("/Math")]
    [Route("/Math/{A}{B}")]
    public class AddUs : IReturn<AddUsResponse>
    {
        public Single 
    }

    public class AddUsResponse
    {
        public Single Result { get; set; }
    }
}
