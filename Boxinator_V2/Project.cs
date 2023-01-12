﻿using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Boxinator_V2 {
    public class Project {
        private string _name;
        private string _workPath;
        private Image[] images;
        
        public Project(string name, string path) {
            _name = name;
            _workPath = path;
        }

        public void InitializeImages() {
            // Get every jpg/png image in _workPath
            var imagePaths = Directory.EnumerateFiles(_workPath, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".jpg") || s.EndsWith(".png"));
            
            images = new Image[imagePaths.Count()];
            int i = 0;
            foreach (var imagePath in imagePaths) {
                images[i] = new Image(imagePath);
                i++;
            }
        }
        
        public Bitmap GetImage(int index) {
            // Check if index is within range
            if (index < 0 || index >= images.Length) {
                Bitmap error = new Bitmap(100, 100);
                return error;
            }
            return images[index].Get();
        }
        
        public List<PercentageRectangle> GetBoxes(int index) {
            // Check if index is within range
            if (index < 0 || index >= images.Length) {
                return new List<PercentageRectangle>();
            }
            return images[index].GetBoxes();
        }


        public int GetImageCount() {
            return images.Length;
        }
    }
}