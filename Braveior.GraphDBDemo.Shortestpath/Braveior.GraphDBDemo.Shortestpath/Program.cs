using Core.Arango;
using Core.Arango.Protocol;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Braveior.GraphDBDemo.Shortestpath
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var arango = new ArangoContext("Server=http://localhost:8529;User=root;Password=password;");

            //await arango.Database.CreateAsync("shortestpathdemo");

            //await arango.Collection.CreateAsync("shortestpathdemo", "places", ArangoCollectionType.Document);
            //await arango.Collection.CreateAsync("shortestpathdemo", "connections", ArangoCollectionType.Edge);

            //await arango.Graph.CreateAsync("shortestpathdemo", new ArangoGraph
            //{
            //    Name = "trainmapgraph",
            //    EdgeDefinitions = new List<ArangoEdgeDefinition>
            //    {
            //      new ArangoEdgeDefinition()
            //      {
            //        Collection = "connections",
            //        From = new List<string> {"places"},
            //        To = new List<string> { "places" }
            //      }
            //    }
            //});

            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "Inverness",
            //    label = "Inverness"
            //});
            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "Aberdeen",
            //    label = "Aberdeen"
            //});
            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "Leuchars",
            //    label = "Leuchars"
            //});
            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "StAndrews",
            //    label = "StAndrews"
            //});
            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "Edinburgh",
            //    label = "Edinburgh"
            //});
            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "Glasgow",
            //    label = "Glasgow"
            //});
            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "York",
            //    label = "York"
            //});
            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "Carlisle",
            //    label = "Carlisle"
            //});
            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "Birmingham",
            //    label = "Birmingham"
            //});
            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "London",
            //    label = "London"
            //});
            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "Brussels",
            //    label = "Brussels"
            //});
            //await arango.Graph.Vertex.CreateAsync("shortestpathdemo", "trainmapgraph", "places", new
            //{
            //    Key = "Cologne",
            //    label = "Cologne"
            //});


            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65828",
            //    From = "places/Inverness",
            //    To = "places/Aberdeen",
            //    travelTime = 3
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65830",
            //    From = "places/Aberdeen",
            //    To = "places/Inverness",
            //    travelTime = 2.5
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65832",
            //    From = "places/Aberdeen",
            //    To = "places/Leuchars",
            //    travelTime = 1.5
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65834",
            //    From = "places/Leuchars",
            //    To = "places/Aberdeen",
            //    travelTime = 1
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65836",
            //    From = "places/Leuchars",
            //    To = "places/Edinburgh",
            //    travelTime = 1.5
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65838",
            //    From = "places/Edinburgh",
            //    To = "places/Leuchars",
            //    travelTime = 3
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65840",
            //    From = "places/Edinburgh",
            //    To = "places/Glasgow",
            //    travelTime = 1
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65842",
            //    From = "places/Glasgow",
            //    To = "places/Edinburgh",
            //    travelTime = 1
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65844",
            //    From = "places/Edinburgh",
            //    To = "places/York",
            //    travelTime = 3.5
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65846",
            //    From = "places/York",
            //    To = "places/Edinburgh",
            //    travelTime = 4
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65848",
            //    From = "places/Glasgow",
            //    To = "places/Carlisle",
            //    travelTime = 1
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65850",
            //    From = "places/Carlisle",
            //    To = "places/Glasgow",
            //    travelTime = 1
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65852",
            //    From = "places/Carlisle",
            //    To = "places/York",
            //    travelTime = 2.5
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65854",
            //    From = "places/York",
            //    To = "places/Carlisle",
            //    travelTime = 3.5
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65856",
            //    From = "places/Carlisle",
            //    To = "places/Birmingham",
            //    travelTime = 2
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65858",
            //    From = "places/Birmingham",
            //    To = "places/Carlisle",
            //    travelTime = 1
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65860",
            //    From = "places/Birmingham",
            //    To = "places/London",
            //    travelTime = 1.5
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65862",
            //    From = "places/London",
            //    To = "places/Birmingham",
            //    travelTime = 2.5
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65864",
            //    From = "places/Leuchars",
            //    To = "places/StAndrews",
            //    travelTime = 0.2
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65866",
            //    From = "places/StAndrews",
            //    To = "places/Leuchars",
            //    travelTime = 0.2
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65868",
            //    From = "places/York",
            //    To = "places/London",
            //    travelTime = 1.8
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65870",
            //    From = "places/London",
            //    To = "places/York",
            //    travelTime = 2
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65872",
            //    From = "places/London",
            //    To = "places/Brussels",
            //    travelTime = 2.5
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65874",
            //    From = "places/Brussels",
            //    To = "places/London",
            //    travelTime = 3.5
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65876",
            //    From = "places/Brussels",
            //    To = "places/Cologne",
            //    travelTime = 2
            //});
            //await arango.Graph.Edge.CreateAsync("shortestpathdemo", "trainmapgraph", "connections", new
            //{
            //    Key = "65878",
            //    From = "places/Cologne",
            //    To = "places/Brussels",
            //    travelTime = 1.5
            //});

            //SHORTEST PATH ALGORITHM
            //var route = await arango.Query.ExecuteAsync<JObject>("shortestpathdemo",
            // $"FOR v, e IN OUTBOUND SHORTEST_PATH 'places/Aberdeen' TO 'places/London' GRAPH 'trainmapgraph' RETURN {{ place: v.label, travelTime: e.travelTime}}");

            //K-SHORTEST PATH ALGORITHM
            var result = await arango.Query.ExecuteAsync<JObject>("shortestpathdemo",
             $"FOR p IN OUTBOUND K_SHORTEST_PATHS 'places/Aberdeen' TO 'places/London' GRAPH 'trainmapgraph' LIMIT 3 RETURN {{ places: p.vertices[*].label, travelTimes: p.edges[*].travelTime, travelTimeTotal: SUM(p.edges[*].travelTime) }}");


        }
    }
}
