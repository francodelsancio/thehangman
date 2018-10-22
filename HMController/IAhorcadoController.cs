namespace HMController
{
    public interface IAhorcadoController
    {
        void AddWord(string word);
        int GetAvailableAttempts();
        bool PayerHasWon();
        void ResetController();
        TestResult TestLetter(char letter);
        int TotalAttempts();
    }
}