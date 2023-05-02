﻿using Microsoft.AspNetCore.Mvc;
//using Steeltoe.Common.Discovery;

namespace MovieAPI.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //DiscoveryHttpClientHandler _handler;
        //public ValuesController( IDiscoveryClient client)
        //{
        //    _handler = new DiscoveryHttpClientHandler(client);
        //}

        // GET api/values/5
        [HttpGet("api/movie")]
        public ActionResult<string> GetMoviesApi()
        {
            string data = "[{\"id\":1,\"Title\":\"Avatar\",\"Year\":\"2009\",\"Rated\":\"PG-13\",\"Released\":\"18 Dec 2009\",\"Runtime\":\"162 min\",\"Genre\":\"Action, Adventure, Fantasy\",\"Director\":\"James Cameron\",\"Writer\":\"James Cameron\",\"Actors\":\"Sam Worthington, Zoe Saldana, Sigourney Weaver, Stephen Lang\",\"Plot\":\"A paraplegic marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.\",\"Language\":\"English, Spanish\",\"Country\":\"USA, UK\"},{\"id\":2,\"Title\":\"I Am Legend\",\"Year\":\"2007\",\"Rated\":\"PG-13\",\"Released\":\"14 Dec 2007\",\"Runtime\":\"101 min\",\"Genre\":\"Drama, Horror, Sci-Fi\",\"Director\":\"Francis Lawrence\",\"Writer\":\"Mark Protosevich (screenplay), Akiva Goldsman (screenplay), Richard Matheson (novel), John William Corrington, Joyce Hooper Corrington\",\"Actors\":\"Will Smith, Alice Braga, Charlie Tahan, Salli Richardson-Whitfield\",\"Plot\":\"Years after a plague kills most of humanity and transforms the rest into monsters, the sole survivor in New York City struggles valiantly to find a cure.\",\"Language\":\"English\",\"Country\":\"USA\"},{\"id\":3,\"Title\":\"300\",\"Year\":\"2006\",\"Rated\":\"R\",\"Released\":\"09 Mar 2007\",\"Runtime\":\"117 min\",\"Genre\":\"Action, Drama, Fantasy\",\"Director\":\"Zack Snyder\",\"Writer\":\"Zack Snyder (screenplay), Kurt Johnstad (screenplay), Michael Gordon (screenplay), Frank Miller (graphic novel), Lynn Varley (graphic novel)\",\"Actors\":\"Gerard Butler, Lena Headey, Dominic West, David Wenham\",\"Plot\":\"King Leonidas of Sparta and a force of 300 men fight the Persians at Thermopylae in 480 B.C.\",\"Language\":\"English\",\"Country\":\"USA\"},{\"id\":4,\"Title\":\"The Avengers\",\"Year\":\"2012\",\"Rated\":\"PG-13\",\"Released\":\"04 May 2012\",\"Runtime\":\"143 min\",\"Genre\":\"Action, Sci-Fi, Thriller\",\"Director\":\"Joss Whedon\",\"Writer\":\"Joss Whedon (screenplay), Zak Penn (story), Joss Whedon (story)\",\"Actors\":\"Robert Downey Jr., Chris Evans, Mark Ruffalo, Chris Hemsworth\",\"Plot\":\"Earth's mightiest heroes must come together and learn to fight as a team if they are to stop the mischievous Loki and his alien army from enslaving humanity.\",\"Language\":\"English, Russian\",\"Country\":\"USA\"},{\"id\":5,\"Title\":\"The Wolf of Wall Street\",\"Year\":\"2013\",\"Rated\":\"R\",\"Released\":\"25 Dec 2013\",\"Runtime\":\"180 min\",\"Genre\":\"Biography, Comedy, Crime\",\"Director\":\"Martin Scorsese\",\"Writer\":\"Terence Winter (screenplay), Jordan Belfort (book)\",\"Actors\":\"Leonardo DiCaprio, Jonah Hill, Margot Robbie, Matthew McConaughey\",\"Plot\":\"Based on the true story of Jordan Belfort, from his rise to a wealthy stock-broker living the high life to his fall involving crime, corruption and the federal government.\",\"Language\":\"English, French\",\"Country\":\"USA\"},{\"id\":6,\"Title\":\"Interstellar\",\"Year\":\"2014\",\"Rated\":\"PG-13\",\"Released\":\"07 Nov 2014\",\"Runtime\":\"169 min\",\"Genre\":\"Adventure, Drama, Sci-Fi\",\"Director\":\"Christopher Nolan\",\"Writer\":\"Jonathan Nolan, Christopher Nolan\",\"Actors\":\"Ellen Burstyn, Matthew McConaughey, Mackenzie Foy, John Lithgow\",\"Plot\":\"A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.\",\"Language\":\"English\",\"Country\":\"USA, UK\"}]";
            return data;
        }
    }
}
