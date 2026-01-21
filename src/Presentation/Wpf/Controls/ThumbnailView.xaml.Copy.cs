using System;
using BerryAIGC.Common;
using System.Diagnostics;
using System.Net;
using System.Security.Policy;
using System.Threading;
using System.Windows;
using BerryAIGC.Civitai;
using BerryAIGC.Civitai.Models;
using BerryAIGC.Toolkit.Models;
using BerryAIGC.Toolkit.Services;

namespace BerryAIGC.Toolkit.Controls
{
    public partial class ThumbnailView
    {
        private async void SearchModel(object obj)
        {
            if (Model.CurrentImage?.ModelHash == null) return;
            
            var hash = Model.CurrentImage.ModelHash;

            using (var client = new CivitaiClient())
            {
                try
                {
                    var modelVersion = await client.GetModelVersionsByHashAsync(hash, CancellationToken.None);

                    Process.Start("explorer.exe", $"\"https://civitai.com/models/{modelVersion.ModelId}?modelVersionId={modelVersion.Id}\"");
                }
                catch (CivitaiRequestException e) when (e.StatusCode == HttpStatusCode.NotFound)
                {
                    var message = "The requested model hash was not found";
                    await ServiceLocator.MessageService.Show(message, "Search Model", PopupButtons.OK);
                }
            }
        }
        
    }
}







