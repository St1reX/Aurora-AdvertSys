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

            migrationBuilder.Sql(@"
                CREATE PROCEDURE FilterAdverts
                @CompanyID INT = NULL,
                @PositionID INT = NULL,
                @SeniorityLevelID INT = NULL,
                @MinSalary DECIMAL(7,2) = NULL,
                @MaxSalary DECIMAL(7,2) = NULL,
                @CvMandatory BIT = NULL,
                @Latitude DECIMAL(9, 7) = NULL,
                @Longitude DECIMAL(9, 7) = NULL,
                @MaxDistance FLOAT = NULL,
                @Amount INT = NULL,
                @Offset INT = NULL
                AS
                BEGIN
                SET NOCOUNT ON;

                SELECT * FROM Advert 
                JOIN dbo.Address ON (Advert.AdvertAddressID = dbo.Address.AddressID)
                WHERE 
                    (@CompanyID IS NULL OR CompanyID = @CompanyID)
                    AND (@PositionID IS NULL OR PositionID = @PositionID)
                    AND (@SeniorityLevelID IS NULL OR SeniorityLevelID = @SeniorityLevelID)
                    AND (@MinSalary IS NULL OR MinSalary >= @MinSalary)
                    AND (@MaxSalary IS NULL OR MaxSalary <= @MaxSalary)
                    AND (@CvMandatory IS NULL OR CvMandatory = @CvMandatory)
                    AND (@Latitude IS NULL OR dbo.GetDistanceInKm(@Latitude, @Longitude, Latitude, Longitude) <= COALESCE(@MaxDistance, 5))
                ORDER BY AdvertID
                OFFSET COALESCE(@Offset, 0) ROWS FETCH NEXT COALESCE(@Amount, 10) ROWS ONLY;
                END;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION dbo.GetDistanceInKm");
            migrationBuilder.Sql("DROP PROCEDURE dbo.FilterAdverts ");
        }
    }
}
