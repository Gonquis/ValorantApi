namespace ValorantApi.DTOs
{
    public class ResultDTO<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public ResultDTO(bool isSuccess, string message, T data = default!)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }

        public static ResultDTO<T> Success(T data, string message = "")
        {
            return new ResultDTO<T>(true, message, data);
        }

        public static ResultDTO<T> Failure(string message)
        {
            return new ResultDTO<T>(false, message);
        }
    }

}
