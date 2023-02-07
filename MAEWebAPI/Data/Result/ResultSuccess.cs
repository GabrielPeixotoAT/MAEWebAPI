namespace MAEWebAPI.Data.Result
{
    public class ResultSuccess<Tresult, TFail> : Result<Tresult, TFail>
    {
        public ResultSuccess(Tresult success, string? message = null)
        {
            this.message = message;
            this.success = true;
            this.hasError = false;
            this.result = success;
        }
    }
    public class ResultSuccess<Tresult> : Result<Tresult>
    {
        public ResultSuccess(Tresult success, string? message = null)
        {
            this.message = message;
            this.success = true;
            this.hasError = false;
            this.result = success;
        }
    }
    public class ResultSuccess : Result
    {
        public ResultSuccess(string? message = null)
        {
            this.message = message;
            this.success = true;
            this.hasError = false;
        }
    }
}
