namespace AzureFunctionSample

open Microsoft.Azure.WebJobs
open Microsoft.AspNetCore.Mvc
open Microsoft.AspNetCore.Http

module HttpTrigger = 

    [<FunctionName "hello">]
    let run (([<HttpTrigger(Extensions.Http.AuthorizationLevel.Anonymous, "GET", "POST", Route="api/v1/{*path}")>] req: HttpRequest)) = 
        "hello world"
        |> OkObjectResult :> ActionResult 
        |> async.Return 
        |> Async.StartAsTask