using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamSkillsForms.Framework
{
    public class MessageService : IMessageService
    {
        public Task ShowError(string message)
        {
            return Application.Current.MainPage.DisplayAlert("Error", message, "OK");
        }
    }

    public interface IMessageService
    {
        Task ShowError(string message); 
    }
}