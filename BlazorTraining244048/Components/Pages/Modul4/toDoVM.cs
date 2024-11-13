namespace BlazorTraining244048.Components.Pages.Modul4
{
    public class ToDoVM
    {
        public ToDoModel TodoO;
        public ToDoVM(IHttpClientFactory _http)
        {
            using (var client= _http.CreateClient())
            {
                TodoO = client.GetFromJsonAsync<ToDoModel>("https://dummyjson.com/todos").Result;
            }
        }
    }
}
