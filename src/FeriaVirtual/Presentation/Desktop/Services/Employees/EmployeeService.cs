﻿using FeriaVirtual.App.Desktop.SeedWork.Filters;
using FeriaVirtual.App.Desktop.Services.Employees.Dto;
using FeriaVirtual.App.Desktop.Services.Employees.Exceptions;
using FeriaVirtual.App.Desktop.Services.Employees.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace FeriaVirtual.App.Desktop.Services.Employees
{
    public class EmployeeService
        : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl = "https://localhost:44315";
        private readonly Uri _uri;


        public EmployeeService(HttpClient httpClient)
        {
            _uri = new Uri(_remoteServiceBaseUrl);
            _httpClient = httpClient;
            _httpClient.BaseAddress = _uri;
        }

        public async Task<EmployeeCounterViewModel> GetNumberOfEmployees()
        {
            var request = new HttpRequestMessage {
                Method = new HttpMethod("GET")
            };
            request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
            var response = await _httpClient.GetAsync("api/employees/count");
            var stringResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return !response.IsSuccessStatusCode
                ? new EmployeeCounterViewModel {
                    Total = 0
                }
                : JsonConvert.DeserializeObject<EmployeeCounterViewModel>(stringResponse);
        }


        public async Task<List<EmployeesViewModel>> GetAllEmployees(int pageNumber)
        {
            var response = await _httpClient.GetAsync($"api/employees/all/{pageNumber}");
            var stringResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return !response.IsSuccessStatusCode
                ? null
                : JsonConvert.DeserializeObject<List<EmployeesViewModel>>(stringResponse);
        }


        public async Task<List<EmployeesViewModel>> GetEmployeesByCriteria
            (Criteria criteria)
        {
            string url = $"api/employees/searchbycriteria/{criteria.CriteriaType}/{criteria.CriteriaValue}/{criteria.PageNumber}";
            var response = await _httpClient.GetAsync(url);
            var stringResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return !response.IsSuccessStatusCode
                ? null
                : JsonConvert.DeserializeObject<List<EmployeesViewModel>>(stringResponse);
        }


        public async Task<string> CreateEmployee(CreateUserDto employeeDto)
        {
            var request = new HttpRequestMessage {
                Content = new StringContent(JsonConvert.SerializeObject(employeeDto))
            };
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("api/users/create", request.Content);
            string stringResponse =  await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if(!response.IsSuccessStatusCode) {
                throw new InvalidCreateEmployeeException(stringResponse);
            }
            return stringResponse;
        }


        public async Task<string> UpdateEmployee(UpdateUserDto employeeDto)
        {
            var request = new HttpRequestMessage {
                Content = new StringContent(JsonConvert.SerializeObject(employeeDto))
            };
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("api/users/create", request.Content);
            string stringResponse =  await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if(!response.IsSuccessStatusCode) {
                throw new InvalidCreateEmployeeException(stringResponse);
            }
            return stringResponse;
        }





    }
}
