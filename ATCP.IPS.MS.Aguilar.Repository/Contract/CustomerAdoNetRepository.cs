﻿using ATCP.IPS.MS.Aguilar.Model.Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCP.IPS.MS.Aguilar.Repository.Contract
{
    public class CustomerAdoNetRepository : ICustomerAdoNetRepository
    {
        private readonly string _connectionString;
        public CustomerAdoNetRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteCustomer", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public IList<Customers> Get()
        {
            var customers = new List<Customers>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllCustomers", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    bool isActive;
                    bool.TryParse(rdr["IsActive"].ToString(), out isActive);
                    Customers customer = new Customers();
                    customer.CustomerId = Convert.ToInt32(rdr["CustomerId"]);
                    customer.FirstName = rdr["FirstName"].ToString();
                    customer.LastName = rdr["LastName"].ToString();
                    customer.Age = Convert.ToInt32(rdr["Age"]);
                    customer.Gender = rdr["Gender"].ToString();
                    customer.Address = rdr["Address"].ToString();
                    customer.IsActive = isActive;
                    customer.CreatedBy = rdr["CreatedBy"].ToString();
                    customers.Add(customer);
                }
                con.Close();
            }
            return customers;
        }
        public Customers GetById(int id)
        {
            Customers customer = new Customers();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetCustomer", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    bool isActive;
                    bool.TryParse(rdr["IsActive"].ToString(), out isActive);
                    customer.CustomerId = Convert.ToInt32(rdr["CustomerId"]);
                    customer.FirstName = rdr["FirstName"].ToString();
                    customer.MiddleName = rdr["MiddleName"].ToString();
                    customer.LastName = rdr["LastName"].ToString();
                    customer.Age = Convert.ToInt32(rdr["Age"]);
                    customer.Gender = rdr["Gender"].ToString();
                    customer.Address = rdr["Address"].ToString();
                    customer.IsActive = isActive;
                    customer.CreatedBy = rdr["CreatedBy"].ToString();
                }
            }
            return customer;
        }
        public void Insert(Customers entity)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddCustomer", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@FirstName", entity.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", entity.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", entity.LastName);
                cmd.Parameters.AddWithValue("@Age", entity.Age);
                cmd.Parameters.AddWithValue("@Address", entity.Address);
                cmd.Parameters.AddWithValue("@Gender", entity.Gender);
                cmd.Parameters.AddWithValue("@IsActive", entity.IsActive);
                cmd.Parameters.AddWithValue("@CreatedBy", entity.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDttm", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Update(Customers entity)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateCustomer", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Id", entity.CustomerId);
                cmd.Parameters.AddWithValue("@FirstName", entity.FirstName);
                cmd.Parameters.AddWithValue("@LastName", entity.LastName);
                cmd.Parameters.AddWithValue("@MiddleName", entity.MiddleName);
                cmd.Parameters.AddWithValue("@Age", entity.Age);
                cmd.Parameters.AddWithValue("@Address", entity.Address);
                cmd.Parameters.AddWithValue("@Gender", entity.Gender);
                cmd.Parameters.AddWithValue("@IsActive", entity.IsActive);
                cmd.Parameters.AddWithValue("@UpdatedBy", entity.UpdatedBy);
                cmd.Parameters.AddWithValue("@UpdatedDttm", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
