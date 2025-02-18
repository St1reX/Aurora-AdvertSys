using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGetDistanceFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE FUNCTION dbo.GetDistanceInKm(
                    @lat1 FLOAT, 
                    @lon1 FLOAT, 
                    @lat2 FLOAT, 
                    @lon2 FLOAT
                )
                RETURNS FLOAT
                AS
                BEGIN
                    DECLARE @point1 GEOGRAPHY = GEOGRAPHY::Point(@lat1, @lon1, 4326);
                    DECLARE @point2 GEOGRAPHY = GEOGRAPHY::Point(@lat2, @lon2, 4326);
                    RETURN @point1.STDistance(@point2) / 1000.0;
                END;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION dbo.GetDistanceInKm");
        }
    }
}
