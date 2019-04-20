﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BrowseSharp.Browsers.Core;
using BrowseSharp.Types;
using BrowseSharp.Types.Html;
using RestSharp;

namespace BrowseSharp
{
    /// <summary>
    /// Browser interface for BrowseSharp
    /// </summary>
    public interface IBrowser : IBrowserCore
    {
        /// <summary>
        /// Execute method that creates a document from an http request
        /// </summary>
        /// <param name="request">Request to be made</param>
        /// <returns>Response Document</returns>
        IDocument Execute(IRestRequest request);

        /// <summary>
        /// Execute method that creates a document from an http get request
        /// </summary>
        /// <param name="request">Request to be made</param>
        /// <param name="httpMethod"></param>
        /// <returns>Response Document</returns>
        IDocument ExecuteAsGet(IRestRequest request, string httpMethod);

        /// <summary>
        /// Execute method that creates a document from an http post request
        /// </summary>
        /// <param name="request">Request to be made</param>
        /// <param name="httpMethod"></param>
        /// <returns>Response Document</returns>
        IDocument ExecuteAsPost(IRestRequest request, string httpMethod);

        /// <summary>
        /// Execute method that creates a document from an asynchronous http request
        /// </summary>
        /// <param name="request">Request to be made</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> ExecuteTaskAsync(IRestRequest request, CancellationToken token);

        /// <summary>
        /// Execute method that creates a document from an asynchronous http request
        /// </summary>
        /// <param name="request">Request to be made</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> ExecuteTaskAsync(IRestRequest request);

        /// <summary>
        /// Execute method that creates a document from an asynchronous http get request
        /// </summary>
        /// <param name="request">Request to be made</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> ExecuteGetTaskAsync(IRestRequest request);

        /// <summary>
        /// Execute method that creates a document from an asynchronous http get request
        /// </summary>
        /// <param name="request">Request to be made</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> ExecuteGetTaskAsync(IRestRequest request, CancellationToken token);

        /// <summary>
        /// Execute method that creates a document from an asynchronous http post request
        /// </summary>
        /// <param name="request">Request to be made</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> ExecutePostTaskAsync(IRestRequest request);

        /// <summary>
        /// Execute method that creates a document from an asynchronous http post request
        /// </summary>
        /// <param name="request">Request to be made</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> ExecutePostTaskAsync(IRestRequest request, CancellationToken token);
        
        /// <summary>
        /// Method that makes a get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <returns>Response Document</returns>
        IDocument Navigate(string uri);

        /// <summary>
        /// Method that makes a get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <returns>Response Document</returns>
        IDocument Navigate(Uri uri);
        
        /// <summary>
        /// Method that makes a get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="headers">Headers to be sent</param>
        /// <returns>Response Document</returns>
        IDocument Navigate(string uri, Dictionary<string,string> headers);
        
        /// <summary>
        /// Method that makes a get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="headers">Headers to be sent</param>
        /// <returns>Response Document</returns>
        IDocument Navigate(Uri uri, Dictionary<string,string> headers);

        /// <summary>
        /// Method that makes a get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="headers">Headers to be sent</param>
        /// <param name="formData">Form data to be sent</param>
        /// <returns>Response Document</returns>
        IDocument Navigate(string uri, Dictionary<string,string> headers, Dictionary<string,string> formData);
        
        /// <summary>
        /// Method that makes a get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="headers">Headers to be sent</param>
        /// <param name="formData">Form data to be sent</param>
        /// <returns>Response Document</returns>
        IDocument Navigate(Uri uri, Dictionary<string,string> headers, Dictionary<string,string> formData);

        /// <summary>
        /// Method that makes an asynchronous get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> NavigateAsync(string uri);

        /// <summary>
        /// Method that makes an asynchronous get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> NavigateAsync(Uri uri);
        
        /// <summary>
        /// Method that makes an asynchronous get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="headers">Headers to be sent</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> NavigateAsync(string uri, Dictionary<string,string> headers);
        
        /// <summary>
        /// Method that makes an asynchronous get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="headers">Headers to be sent</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> NavigateAsync(Uri uri, Dictionary<string,string> headers);
        
        /// <summary>
        /// Method that makes an asynchronous get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="headers">Headers to be sent</param>
        /// <param name="formData">Form data to be sent</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> NavigateAsync(string uri, Dictionary<string,string> headers, Dictionary<string,string> formData);
        
        /// <summary>
        /// Method that makes an asynchronous get request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="headers">Headers to be sent</param>
        /// <param name="formData">Form data to be sent</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> NavigateAsync(Uri uri, Dictionary<string,string> headers, Dictionary<string,string> formData);
        
        /// <summary>
        /// Method that makes a post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <returns>Response Document</returns>
        IDocument Submit(string uri);

        /// <summary>
        /// Method that makes a post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <returns>Response Document</returns>
        IDocument Submit(Uri uri);

        /// <summary>
        /// Method that makes a post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="formData">Form data to be sent</param>
        /// <returns>Response Document</returns>
        IDocument Submit(string uri, Dictionary<string,string> formData);

        /// <summary>
        /// Method that makes a post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="formData">Form data to be sent</param>
        /// <returns>Response Document</returns>
        IDocument Submit(Uri uri, Dictionary<string,string> formData);

        /// <summary>
        /// Method that makes a post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="formData">Form data to be sent</param>
        /// <param name="headers">Headers to be sent</param>
        /// <returns>Response Document</returns>
        IDocument Submit(string uri, Dictionary<string, string> formData, Dictionary<string, string> headers);

        /// <summary>
        /// Method that makes a post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="formData">Form data to be sent</param>
        /// <param name="headers">Headers to be sent</param>
        /// <returns>Response Document</returns>
        IDocument Submit(Uri uri, Dictionary<string, string> formData, Dictionary<string, string> headers);

        /// <summary>
        /// Submits form
        /// </summary>
        /// <param name="form">Form to be submitted</param>
        /// <returns>Response Document</returns>
        IDocument SubmitForm(Form form);

        /// <summary>
        /// Submits form
        /// </summary>
        /// <param name="form">Form to be submitted</param>
        /// <param name="headers">Headers to be sent</param>
        /// <returns>Response Document</returns>
        IDocument SubmitForm(Form form, Dictionary<string, string> headers);
        
        /// <summary>
        /// Method that makes an asynchronous post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> SubmitAsync(string uri);

        /// <summary>
        /// Method that makes an asynchronous post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> SubmitAsync(Uri uri);
        
        /// <summary>
        /// Method that makes an asynchronous post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="formData">Form data to be sent</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> SubmitAsync(string uri, Dictionary<string,string> formData);

        /// <summary>
        /// Method that makes an asynchronous post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="formData">Form data to be sent</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> SubmitAsync(Uri uri, Dictionary<string,string> formData);

        /// <summary>
        /// Method that makes an asynchronous post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="formData">Form data to be sent</param>
        /// <param name="headers">Headers to be submitted</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> SubmitAsync(string uri, Dictionary<string, string> formData,
            Dictionary<string, string> headers);

        /// <summary>
        /// Method that makes an asynchronous post request and creates a document
        /// </summary>
        /// <param name="uri">Uri for request</param>
        /// <param name="formData">Form data to be sent</param>
        /// <param name="headers">Headers to be submitted</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> SubmitAsync(Uri uri, Dictionary<string, string> formData, Dictionary<string, string> headers);

        /// <summary>
        /// Submits a form asynchronously
        /// </summary>
        /// <param name="form">Form to be submitted</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> SubmitFormAsync(Form form);

        /// <summary>
        /// Submits a form asynchronously
        /// </summary>
        /// <param name="form">Form to be submitted</param>
        /// <param name="headers">Headers to be submitted</param>
        /// <returns>Response Document Task</returns>
        Task<IDocument> SubmitFormAsync(Form form, Dictionary<string, string> headers);
        
        /// <summary>
        /// Gets current document from the current request
        /// </summary>
        /// <returns>Current Document</returns>
        IDocument Document { get; }

    }
}