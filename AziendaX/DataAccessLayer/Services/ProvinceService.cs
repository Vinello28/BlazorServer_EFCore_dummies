using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    public class ProvinceService
    {
        protected readonly AziendaXdbContext _context;

        public ProvinceService(AziendaXdbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Asynchronous method that returns all provinces in the database
        /// </summary>
        /// <returns></returns>
        public async Task<List<Province>> GetProvincesAsync()
        {
            return await _context.Provinces.ToListAsync();
        }

        /// <summary>
        /// Asynchronous method that returns a province by its sigla
        /// </summary>
        /// <param name="sigla"></param>
        /// <returns></returns>
        public async Task<Province> GetProvinceBySiglaAsync(string sigla)
        {
            return await _context.Provinces.FindAsync(sigla);
        }

        /// <summary>
        /// Asynchronous method that adds a province to the database
        /// </summary>
        /// <param name="province"></param>
        /// <returns></returns>
        public async Task AddProvinceAsync(Province province)
        {
            _context.Provinces.Add(province);
            await _context.SaveChangesAsync();
        }
        
        /// <summary>
        /// Asynchronous method that updates a province in the database
        /// </summary>
        /// <param name="province"></param>
        /// <returns></returns>
        public async Task UpdateProvinceAsync(Province province)
        {
            _context.Entry(province).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method that deletes a province from the database
        /// </summary>
        /// <param name="sigla"></param>
        /// <returns></returns>
        public async Task DeleteProvinceAsync(string sigla)
        {
            var province = await _context.Provinces.FindAsync(sigla);
            _context.Provinces.Remove(province);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method that checks if a province exists in the database
        /// </summary>
        /// <param name="sigla"></param>
        /// <returns></returns>
        public bool ProvinceExistsAsync(string sigla)
        {
            return _context.Provinces.Any(e => e.Sigla == sigla);
        }

        /// <summary>
        /// Method that checks if a province exists in the database
        /// </summary>
        /// <param name="sigla"></param>
        /// <returns></returns>
        public bool ProvinceExists(string sigla)
        {
            return _context.Provinces.Any(e => e.Sigla == sigla);
        }

        /// <summary>
        /// Method that returns all provinces in the database
        /// </summary>
        /// <returns></returns>
        public List<Province> GetProvinces()
        {
            return _context.Provinces.ToList();
        }

        /// <summary>
        /// Method that returns a province by its sigla
        /// </summary>
        /// <param name="sigla"></param>
        /// <returns></returns>
        public Province GetProvinceBySigla(string sigla)
        {
            return _context.Provinces.Find(sigla);
        }

        /// <summary>
        /// Method that adds a province to the database
        /// </summary>
        /// <param name="province"></param>
        public void AddProvince(Province province)
        {
            _context.Provinces.Add(province);
            _context.SaveChanges();
        }

        /// <summary>
        /// Method that updates a province in the database
        /// </summary>
        /// <param name="province"></param>
        public void UpdateProvince(Province province)
        {
            _context.Entry(province).State = EntityState.Modified;
            _context.SaveChanges();
        }

        /// <summary>
        /// Method that deletes a province from the database
        /// </summary>
        /// <param name="sigla"></param>
        public void DeleteProvince(string sigla)
        {
            var province = _context.Provinces.Find(sigla);
            _context.Provinces.Remove(province);
            _context.SaveChanges();
        }


    }
}
