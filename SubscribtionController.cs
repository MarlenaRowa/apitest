
using Catalog;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net;

namespace API
{

    // Hier Soll  neu Api Route für subscribtion sein, wir sollen Get und post bekommen 
    // ich denke(?) und ich sätze es wird funktionieren wie bei ItemsController 

    // wir brauchen dann aus subscription für programm abfrage, wir sollen datei wie id, name, version bekommen
    //und ein subscription trigger, aber ich kann mich noch nicht vostellen was und wie soll es funktionieren 
    


    // bekommt von Subscription id, name ,version
    // zum programmhandler gehen mit id, name
    // schickt aktuelle id name und versionOnRobot zurück an api und diese weiter zur subscription
    // GET / items
    [ApiController]
    public class SubscribtionController
    {   

        // We get id, name, version from the subscription 
        [HttpPost]
        [Route("v2/subscription/trigger")]
        public void SubscriptionNotification(ProgramDto programDto)
        {
            Console.WriteLine("This is the data {0}, {1}, {2}", programDto.Id, programDto.Name, programDto.Version);
            // TODO
            // Go to programmhandler and which sends the versionOnRobot back to this api (to /handler)
        }




        // Programm handler sends back the id, name and versionOnRobot
        //TODO send to subscription
        [HttpPost]
        [Route("v2/subscription/handler")]
        public void ProgrammHandlerNotification(ProgramDto programDto)
        {
            System.Console.WriteLine("This is the data from the programhandler {0}, {1}, {2}", programDto.Id, programDto.Name, programDto.Version);
        }

    }
}
