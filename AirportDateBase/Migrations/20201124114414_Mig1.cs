using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportDateBase.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_passenger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pasport_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flight_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plane_ID = table.Column<long>(type: "bigint", nullable: true),
                    Crew_ID = table.Column<long>(type: "bigint", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Departure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arrival = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time_flight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TicketsID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Flight_Tickets_TicketsID",
                        column: x => x.TicketsID,
                        principalTable: "Tickets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Crew",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_1ID = table.Column<long>(type: "bigint", nullable: true),
                    Employee_2ID = table.Column<long>(type: "bigint", nullable: true),
                    Employee_3ID = table.Column<long>(type: "bigint", nullable: true),
                    Hours_flown = table.Column<int>(type: "int", nullable: false),
                    FlightID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crew", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Crew_Flight_FlightID",
                        column: x => x.FlightID,
                        principalTable: "Flight",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plane",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_ID = table.Column<long>(type: "bigint", nullable: true),
                    Employee_ID = table.Column<long>(type: "bigint", nullable: true),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Tonnage = table.Column<int>(type: "int", nullable: false),
                    Technical_parameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Release_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_last_repair = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hours_flown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plane", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Plane_Flight_FlightID",
                        column: x => x.FlightID,
                        principalTable: "Flight",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Posts_ID = table.Column<long>(type: "bigint", nullable: true),
                    FIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<int>(type: "int", nullable: false),
                    Pasport_data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrewID = table.Column<long>(type: "bigint", nullable: true),
                    CrewID1 = table.Column<long>(type: "bigint", nullable: true),
                    CrewID2 = table.Column<long>(type: "bigint", nullable: true),
                    PlaneID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Crew_CrewID",
                        column: x => x.CrewID,
                        principalTable: "Crew",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Crew_CrewID1",
                        column: x => x.CrewID1,
                        principalTable: "Crew",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Crew_CrewID2",
                        column: x => x.CrewID2,
                        principalTable: "Crew",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Plane_PlaneID",
                        column: x => x.PlaneID,
                        principalTable: "Plane",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Type_plane",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_plane = table.Column<long>(type: "bigint", nullable: false),
                    Limit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaneID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_plane", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Type_plane_Plane_PlaneID",
                        column: x => x.PlaneID,
                        principalTable: "Plane",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Post = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Request = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Charge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Posts_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crew_FlightID",
                table: "Crew",
                column: "FlightID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CrewID",
                table: "Employee",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CrewID1",
                table: "Employee",
                column: "CrewID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CrewID2",
                table: "Employee",
                column: "CrewID2");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PlaneID",
                table: "Employee",
                column: "PlaneID");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_TicketsID",
                table: "Flight",
                column: "TicketsID");

            migrationBuilder.CreateIndex(
                name: "IX_Plane_FlightID",
                table: "Plane",
                column: "FlightID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_EmployeeID",
                table: "Posts",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Type_plane_PlaneID",
                table: "Type_plane",
                column: "PlaneID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Type_plane");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Crew");

            migrationBuilder.DropTable(
                name: "Plane");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
