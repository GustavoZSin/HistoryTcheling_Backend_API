using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Mappers;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HistoryTcheling_Backend.Infraestructure.Mappers
{
    public class ImageMapper : IMapper<ImageModel, Image>
    {
        public Image MapToDestination(ImageModel source)
        {
            string base64String = null;

            string fullFilePath = $"{source.FilePath}{source.Name}{source.FileExtension}";

            if (!string.IsNullOrEmpty(source.FilePath) && File.Exists(fullFilePath))
            {
                var fileBytes = File.ReadAllBytes(fullFilePath);
                base64String = Convert.ToBase64String(fileBytes);
            }

            return new Image
            {
                Id = source.Id,
                Name = source.Name,
                FileExtension = source.FileExtension,
                ImageBase64 = base64String
            };
        }

        public ImageModel MapToSource(Image destination)
        {
            return new ImageModel
            {
                Name = destination.Name,
                FileExtension = destination.FileExtension,
                FilePath = destination.FilePath,
            };
        }
    }
}
