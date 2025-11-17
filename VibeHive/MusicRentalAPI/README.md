# Music Rental Management System
This project implements the Music Rental Management System for the VibeHive Hub using:
- ASP.NET Core Web API
- C# Windows Form Application
- RESTful endpoints
- In-memory storage
- Input validation / Error handling

# Running the API
1. Open the solution in Visual Studio
2. Set MusicRentalAPI as the Startup Project
3. Press F5
4. Swagger should open at a URL similar to: https://localhost:7159/swagger

# Running the Windows Forms Client
1. Set MusicRentalClient as the Startup Project
2. Press F5
3. The GUI will open
4. Buttons remain disabled until input is valid

*All API errors are shown through message dialogs*

# API Documentation

## Music Endpoints 

### POST /api/music - Add new album
Example request body:
{
	"id": 489, 
	"title": "American Radio", 
	"artist": "Modern Alibi", 
	"genre": "Alternative", 
	"year": 2025, 
	"available": true
}

Possible Responses:
- 201 Created
- 400 Bad Request

### GET /api/music - Get all albums
Example request body:
[
	{
		"id": 489, 
		"title": "American Radio", 
		"artist": "Modern Alibi", 
		"genre": "Alternative", 
		"year": 2025, 
		"available": true
	}
]

### DELETE /api/music/{id} - Delete an album (only if not rented)
Possible Responses:
- 200 OK (deleted)
- 404 Not Found
- 409 Conflict (album currently rented)

## Rental Endpoints 

### POST /api/rental - Rent an album
Example request body:
{
    "userID": 1,
    "albumID": 489
}

Possible Responses:
- 201 Created
- 404 Not Found (album does not exist)
- 409 Conflict (album already rented)

### POST /api/rental/{id}/return - Return a rented album
Example Request:

POST https://localhost:7159/api/rental/3005/return

Possible Responses:
- 200 OK
- 404 Not Found (RentalID does not exist)
- 409 Conflict (rental already returned)

### GET /api/rental - Get all active rentals
Example response:
[
    {
        "id": 3005,
        "userID": 1,
        "albumID": 489,
        "rentalDate": "2025-01-01T15:00:00",
        "returnDate": null
    }
]

# Seed / Test Data

## Suggested albums to add
Title				Artist				Genre			Year
American Radio		Modern Alibi		Alternative		2025
Weezer				Weezer				Pop				1994
Milliontown			Frost				Metal			2006
Rumours				Fleetwood Mac		Rock			1977

## Test scenario
1. Add three albumns
2. Rent one album
3. Try to rent the same album again
	- Should show 409 conflict
4. Return the rental using RentalID
5. Try returning again
	- Should show 409 conflict
6. Try deleting a rented album
 	- Should show 409 conflict
7. Delete an available album
 	- Should succeed

# Windows Forms Client Features
Add Album
- Validates title, artist, genre, and year
- Add button disabled until input is valid

List Albums
- Displays formatted rows (ID, Title, Artist, Genre, Available)

Rent Album
- Requires numeric UserID & AlbumID
- API errors shown directly

Return Album
- Uses RentalID
- Handles invalid / duplicate returns

View Active Rentals
- Displays formatted rows (RentalID, UserID, Album Title, Genre, Rental Date)
- Joins album data for readability

Usability Features
- Buttons disabled until valid input
- MessageBox displays API messages
- Clean and consistent formatting