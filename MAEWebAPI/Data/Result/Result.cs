namespace MAEWebAPI.Data.Result
{
    public abstract class Result<TResult, TFail>
    {
        public string? message;
        public bool success;
        public bool hasError;
        public TResult result { get; set; }
        public TFail error { get; set; }

    }
    public abstract class Result<TResult>
    {
        public string? message;
        public bool success;
        public bool hasError;
        public TResult result { get; set; }

    }
    public abstract class Result
    {
        public string? message;
        public bool success;
        public bool hasError;
    }
}
