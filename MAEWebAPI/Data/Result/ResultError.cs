namespace MAEWebAPI.Data.Result
{
    public class ResultError<Tresult, TFail> : Result<Tresult, TFail>
    {
        public ResultError(TFail error, string? message = null)
        {

            this.message = message;
            this.success = false;
            this.hasError = true;
            this.error = error;
        }
    }
    public class ResultError<Tresult> : Result<Tresult>
    {
        public ResultError(string? message = null)
        {
            this.message = message;
            this.success = false;
            this.hasError = true;
        }
    }
    public class ResultError : Result
    {
        public ResultError(string? message = null)
        {

            this.message = message;
            this.success = false;
            this.hasError = true;
        }
    }
}
