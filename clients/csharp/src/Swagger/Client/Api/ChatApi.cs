  using System;
  using System.Collections.Generic;
  using Swagger.Client.Common;
  using Swagger.Client.Model;
  namespace Swagger.Client.Api {
    public class ChatApi {
      string basePath;
      private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

      public ChatApi(String basePath = "https://www.bitmex.com/api/v1")
      {
        this.basePath = basePath;
      }

      public ApiInvoker getInvoker() {
        return apiInvoker;
      }

      // Sets the endpoint base url for the services being accessed
      public void setBasePath(string basePath) {
        this.basePath = basePath;
      }

      // Gets the endpoint base url for the services being accessed
      public String getBasePath() {
        return basePath;
      }

      /// <summary>
      /// Send a chat message. 
      /// </summary>
      /// <param name="message"></param>
      /// <returns></returns>
      public chat chat_create (string message) {
        // create path and map variables
        var path = "/chat".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (message == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (message != null){
          if(message is byte[]) {
            formParams.Add("message", message);
          } else {
            string paramStr = (message is DateTime) ? ((DateTime)(object)message).ToString("u") : Convert.ToString(message);
            formParams.Add("message", paramStr);
          }
		}
        try {
          if (typeof(chat) == typeof(byte[])) {
            var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
            return ((object)response) as chat;
          } else {
            var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (chat) ApiInvoker.deserialize(response, typeof(chat));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Get chat messages. 
      /// </summary>
      /// <param name="count"></param>
      /// <returns></returns>
      public List<chat> chat_find (double? count) {
        // create path and map variables
        var path = "/chat".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (count != null){
          string paramStr = (count is DateTime) ? ((DateTime)(object)count).ToString("u") : Convert.ToString(count);
          queryParams.Add("count", paramStr);
		}
        try {
          if (typeof(List<chat>) == typeof(byte[])) {
            var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
            return ((object)response) as List<chat>;
          } else {
            var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (List<chat>) ApiInvoker.deserialize(response, typeof(List<chat>));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      }
    }