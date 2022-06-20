
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
    

    // prüfen programmhandler --> aktuelle Version
    // schicken id programmname --> welche version am robot
    // versionOnRobot id, name zurückschicken


    // bekommt von Subscription id, name ,version
    // zum programmhandler gehen mit id, name
    // schickt aktuelle id name und versionOnRobot zurück an api und diese weiter zur subscription
    // GET / items
    [ApiController]
    [Route("v2/subscription")]
    public class SubscribtionController
    {   
        [HttpPost]
        public void GetSubscription()
        {

        }
    }
}
