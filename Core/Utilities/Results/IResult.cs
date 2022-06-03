namespace Core.Utilities.Results
{
    // Temel Void'ler için
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}
