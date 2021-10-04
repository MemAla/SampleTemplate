using SampleTemplate.Shared.Entities.Enums;
using System;

namespace SampleTemplate.Shared.Extensions
{
    public class ResponseData<T>
    {
        public ResponseDataTypes ResponseDataType { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public DateTime ServerTime { get; set; }
        public int? TotalRowCount { get; set; }
        public T Result { get; set; }

        public ResponseData()
        {
            ServerTime = DateTime.Now;
        }

        public ResponseData<T> Success(T t)
        {
            Code = "INF-00001";
            Message = "İşlem Başarılı";
            ResponseDataType = ResponseDataTypes.Success;
            Result = t;
            return this; 
        }

        public ResponseData<T> NotFound(T t)
        {
            Code = "INF-00002";
            Message = "Kayıt Bulunamadı";
            ResponseDataType = ResponseDataTypes.Error;
            Result = t;
            return this;
        }

        public ResponseData<T> Unauthorized(T t)
        {
            Code = "INF-00004";
            Message = "Yetkiniz Yok";
            ResponseDataType = ResponseDataTypes.Error;
            Result = t;
            return this;
        }

        public ResponseData<T> AlreadyExist(T t)
        {
            Code = "INF-00003";
            Message = "Mevcut Kayıt Bulundu";
            ResponseDataType = ResponseDataTypes.Error;
            Result = t;
            return this;
        }

        public ResponseData<T> Error(T t,string code)
        {
            Code = code;
            Message = code;
            ResponseDataType = ResponseDataTypes.Error;
            Result = t;
            return this;
        }

        public ResponseData<T> Error(T t, string code, String message)
        {
            Code = code;
            Message = message;
            ResponseDataType = ResponseDataTypes.Error;
            Result = t;
            return this;
        }
    }
}
