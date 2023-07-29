using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

using OptimoBcTools.Data;

using Microsoft.OData.ModelBuilder;
using Microsoft.AspNetCore.OData;

namespace OptimoBcTools
{
    public partial class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        partial void OnConfigureServices(IServiceCollection services);

        partial void OnConfiguringServices(IServiceCollection services);

        public void ConfigureServices(IServiceCollection services)
        {
            OnConfiguringServices(services);

            services.AddHttpContextAccessor();
            services.AddCors(options =>
            {
                options.AddPolicy(
                    "AllowAny",
                    x =>
                    {
                        x.AllowAnyHeader()
                        .AllowAnyMethod()
                        .SetIsOriginAllowed(isOriginAllowed: _ => true)
                        .AllowCredentials();
                    });
            });
            var oDataBuilder = new ODataConventionModelBuilder();

            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>("BcAnalysenViewItems");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>("BcAnalysenViewItemLedgerEntries");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>("BcAnalysenViewProduzierteArtikelJahrMonats");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer>("BcScanBenutzers");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice>("BcScanDevices");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>("BcScanProtokollLadelistes");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern>("BcScanProtokollUmlagerns");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikel>("BcScanViewArtikels");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikelLagerbestand>("BcScanViewArtikelLagerbestands");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewBenutzer>("BcScanViewBenutzers");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTour>("BcScanViewDeliveryTours");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>("BcScanViewDeliveryTourGroupedLines");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>("BcScanViewDeliveryTourPlanHeaders");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>("BcScanViewDeliveryTourPlanLines");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDevice>("BcScanViewDevices");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>("BcScanViewItems");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>("BcScanViewItemJournalLines");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLineUmlagernNeueZeilenNr>("BcScanViewItemJournalLineUmlagernNeueZeilenNrs");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteKopf>("BcScanViewLadelisteKopfs");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteZeilen>("BcScanViewLadelisteZeilens");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>("BcScanViewProductionOrders");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>("BcScanViewProductionOrderLines");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderProduced>("BcScanViewProductionOrderProduceds");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>("BcScanViewProtokollLadelistes");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollUmlagern>("BcScanViewProtokollUmlagerns");
            oDataBuilder.EntitySet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewUmlagerungLetzteNummer>("BcScanViewUmlagerungLetzteNummers");

            this.OnConfigureOData(oDataBuilder);


            var model = oDataBuilder.GetEdmModel();
            services.AddControllers().AddOData(opt => { 
              opt.AddRouteComponents("odata/dbOptimoBCLive", model).Count().Filter().OrderBy().Expand().Select().SetMaxTop(null).TimeZone = TimeZoneInfo.Utc;
            });

            

            services.AddDbContext<OptimoBcTools.Data.DbOptimoBcLiveContext>(options =>
            {
              options.UseSqlServer(Configuration.GetConnectionString("dbOptimoBCLiveConnection"));
            });

            services.AddRazorPages();

            OnConfigureServices(services);
        }

        partial void OnConfigure(IApplicationBuilder app, IWebHostEnvironment env);
        partial void OnConfigureOData(ODataConventionModelBuilder builder);
        partial void OnConfiguring(IApplicationBuilder app, IWebHostEnvironment env);

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            OnConfiguring(app, env);
            if (env.IsDevelopment())
            {
                Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.Use((ctx, next) =>
                {
                    return next();
                });
            }
            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();
            IServiceProvider provider = app.ApplicationServices.GetRequiredService<IServiceProvider>();
            app.UseCors("AllowAny");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });

            OnConfigure(app, env);
        }
    }


  public class BlankTriggerAddingConvention : Microsoft.EntityFrameworkCore.Metadata.Conventions.IModelFinalizingConvention
  {
      public virtual void ProcessModelFinalizing(
          Microsoft.EntityFrameworkCore.Metadata.Builders.IConventionModelBuilder modelBuilder,
          Microsoft.EntityFrameworkCore.Metadata.Conventions.IConventionContext<Microsoft.EntityFrameworkCore.Metadata.Builders.IConventionModelBuilder> context)
      {
          foreach (var entityType in modelBuilder.Metadata.GetEntityTypes())
          {
              var table = Microsoft.EntityFrameworkCore.Metadata.StoreObjectIdentifier.Create(entityType, Microsoft.EntityFrameworkCore.Metadata.StoreObjectType.Table);
              if (table != null
                  && entityType.GetDeclaredTriggers().All(t => t.GetDatabaseName(table.Value) == null))
              {
                  entityType.Builder.HasTrigger(table.Value.Name + "_Trigger");
              }

              foreach (var fragment in entityType.GetMappingFragments(Microsoft.EntityFrameworkCore.Metadata.StoreObjectType.Table))
              {
                  if (entityType.GetDeclaredTriggers().All(t => t.GetDatabaseName(fragment.StoreObject) == null))
                  {
                      entityType.Builder.HasTrigger(fragment.StoreObject.Name + "_Trigger");
                  }
              }
          }
      }
  }
}
