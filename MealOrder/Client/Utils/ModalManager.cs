using System.Threading.Tasks;
using Blazored.Modal;
using Blazored.Modal.Services;
using MealOrder.Client.CustomComponents.Modal;

namespace MealOrder.Client.Utils
{
  public class ModalManager
  {
    private readonly IModalService _modalService;

    public ModalManager(IModalService modalService)
    {
      _modalService = modalService;
    }

    public async Task ShowMessageAsync(string title, string message, int duration)
    {
      ModalParameters modalParameters = new();
      modalParameters.Add("Message", message);

      IModalReference modalReference = _modalService.Show<ShowMessagePopupComponent>(title, modalParameters);

      if (duration > 0)
      {
        await Task.Delay(duration);
        modalReference.Close();
      }
    }

    public async Task<bool> ConfirmationAsync(string title, string message)
    {
      ModalParameters modalParameters = new();
      modalParameters.Add("Message", message);

      IModalReference modalRef = _modalService.Show<ConfirmationPopupComponent>(title, modalParameters);
      Task<ModalResult> modalResult = modalRef.Result;

      return !modalResult.IsCanceled;
    }
  }
}