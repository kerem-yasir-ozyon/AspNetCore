using Microsoft.AspNetCore.Mvc.Rendering;
using OtelApp.Data;
using OtelApp.Data.Entities;

namespace OtelApp.Library
{
    public class SelectBoxCustom
    {
        private static AppDbContext _appDbContext;

        public SelectBoxCustom(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public SelectList OtelTuruList(object? selectedValue = null )
        {
            var items = _appDbContext.OtelTurus.Where(u => u.IsActive == true).ToList();

            return (selectedValue is null) ? new SelectList(items, "Id", "Name")
                                           : new SelectList(items, "Id", "Name", selectedValue);
        }

        public SelectList UlkeList(object? selectedValue = null)
        {
            var items = _appDbContext.Ulkeler.Where(u => u.IsActive == true).ToList();

            return (selectedValue is null) ? new SelectList(items, "Id", "Name")
                                           : new SelectList(items, "Id", "Name", selectedValue);
        }

        public SelectList SehirList(object? selectedValue = null)
        {
            var items = _appDbContext.Sehirler.Where(u => u.IsActive == true).ToList();

            return (selectedValue is null) ? new SelectList(items, "Id", "Name")
                                           : new SelectList(items, "Id", "Name", selectedValue);
        }
    }

}
