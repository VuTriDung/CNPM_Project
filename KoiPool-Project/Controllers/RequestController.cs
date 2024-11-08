using Azure.Core;
using KoiPool_Project.Services;
using Microsoft.AspNetCore.Mvc;

public class RequestController : Controller
{
    private readonly RequestService _requestService;

    public RequestController(RequestService requestService)
    {
        _requestService = requestService;
    }

    [HttpPost]
    public IActionResult CreateRequest(KoiPool_Project.Models.RequestModel request)
    {
        _requestService.CreateRequest(request);
        return RedirectToAction("RequestDetails", new { id = request.RequestId });
    }

    [HttpPost]
    public IActionResult UpdateStatus(int requestId, string newStatus)
    {
        _requestService.UpdateRequestStatus(requestId, newStatus);
        return RedirectToAction("RequestDetails", new { id = requestId });
    }

    public IActionResult RequestDetails(int id)
    {
        var request = _requestService.GetRequestsByCustomerId(id);
        return View(request);
    }
}
