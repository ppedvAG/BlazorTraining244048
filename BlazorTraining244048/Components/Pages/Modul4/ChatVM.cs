namespace BlazorTraining244048.Components.Pages.Modul4
{
    public class ChatVM
    {
        public List<ChatModel> Liste { get; set; } = new();
        public event Action OnAdd;
        public void Add(string msg)
        {
            Liste.Add(new ChatModel { Nachricht = msg });
            OnAdd?.Invoke();
        }
    }
}
