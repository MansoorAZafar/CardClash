<p align="center" style="margin-bottom: 0;">
  <a href="https://cardclash.onrender.com/">
    <img src="https://github.com/user-attachments/assets/87beddb0-5d35-4ee0-9fb5-b4d34b864ac8" 
      alt="Gameplay Screenshot" width="600" />
    <br><br><strong>https://cardclash.onrender.com//</strong></a></p>
  </a>
</p>

# CardClash: Clash Cards With Your Opponent!

**Card Clash** is a free, web-based card game using a powerful tech stack:
- Blazor
  - The frontend framework   
- ASP.NET Core Web API
  - The backend framework
- NeonDB (PostGreSQL)
  - The Database used to store the values
- Unity
  - The Game engine used to make the WebGL Game
- Postman & Swagger
  - Used for testing the routes

## Features
- **Modern Tech Stack:** Built with a modern tech stack ensuring a smooth and responsive gaming experience. 💻
- **User Authentication:** Secure login and registration process with unique emails. 🔒
- **Cross-Browser Support:** Works seamlessly on all modern browsers. 🌐
- **Simple Gameplay** Play against the AI and try to pick the greatest card for each round!

## Gameplay 🔥

You and the AI will both pick a card 13 times, (1 for each round), and whoever picks the number with the largest value, wins the round! However, Each card can only be used once and the numbers range from 1-13. Click the card to select it, then select the **battle** button to see who will win the battle!

### Screenshots 📸

<details>
  <summary>Screenshots</summary>

  ![{6E65AB78-402F-445A-8074-2F594309EDFE}](https://github.com/user-attachments/assets/7bdfa0b2-634f-40c1-bfc3-96ed8f38893d)

  ![{D5CE75EE-D112-41E9-84EF-23E93D1B848F}](https://github.com/user-attachments/assets/7e98f0d8-e251-4ab1-af7d-17d98b1c89b2)

  ![{23C47100-4C6C-4932-9570-8D2EF1671E10}](https://github.com/user-attachments/assets/2b41b622-85cf-44a5-b527-de83c04562ed)

  ![{33AD3CEF-12B4-4B41-B5D3-E1B244B61A56}](https://github.com/user-attachments/assets/27ce72b9-ecc8-4d36-89fd-7bdbc4f78744)

  ![{B419E797-3717-40E4-9E87-0FED735FF16A}](https://github.com/user-attachments/assets/33a215d3-a57d-42fd-a3d6-ba230bfc4aaa)

  ![{A8208EEA-C24F-4BE0-B53D-B2A1A5EE9C68}](https://github.com/user-attachments/assets/b29abf53-4d1e-4982-be18-2319ee76cef5)

  ![{B32BF28E-4CFE-4F86-8C98-E2D5A5E3933E}](https://github.com/user-attachments/assets/7709b62b-79a4-4099-b0e7-a9bb5d5bf490)

  ![{CF640C37-7D92-455C-9333-9633D314AD6E}](https://github.com/user-attachments/assets/c59b9b9c-e4d6-4363-a636-f0e61e5281e1)

</details>

## Getting Started 🔰

### Prerequisites

To play Mini Quest, you need:
- A modern web browser (Chrome, Firefox, Safari, Edge, Brave)
- An internet connection

### How to Play 👨‍🏫

1. **Register/Login:**
   - Register an account with a unique username or log in if you already have an account.

2. **Controls:**
   - **Click** Press any card to Selectt them
   - **Battle** Press this button to begin the combat

3. **Objectives:** 🥅
   - Get a higher score than your opponent

### TODO
- If you go back to HOME, you will have to login again
  - Implement JWT or something to keep the session
- Route Protection, Can just go to /game


## Running Locally 🖥️

If you want to run Mini Quest locally, follow these instructions:

### Running the Project Locally

To run this project locally, you'll need to start both the Frontend and Backend. Follow these steps:

1. Cloning the Projects
```bash
git clone https://github.com/MansoorAZafar/CardClash.git          # Get the frontend
git clone https://github.com/MansoorAZafar/CardClashBackend.git   # Get the backend
```

2. Setup Environment Variables for the backend
  - Create a .env file in the root and assign a DB_STR and SECRET_KEY
    - The DB_STR should be a connection string to a PostGreSQL database
    - The SECRET_KEY should be a encoded string for authentication

3. Run the backend
```bash
dotnet restore
dotnet build
dotnet run

# Or with docker
dotnet restore
docker build -t cardclashbackend .
docker run -p 8080:80 cardclashbackend
```
Add /swagger to the URL if you want to test it with swagger.

4. Setup Environment Variables for the frontend
  - Create a .env file in the root and assign a DB_URL
      - DB_URL defines the API db URL (aka the backend URL)

5. Run the Frontend

```bash
dotnet restore
dotnet build
dotnet run

# Or with docker
dotnet restore
docker build -t cardclashbackend .
docker run -p 8080:80 cardclashbackend
```

## Contributing

Contributions are welcome! If you have suggestions for improvements or new features, please submit an issue or a pull request on the [GitHub repository](https://github.com/MansoorAZafar/CardClash).

## Contact

For any questions or feedback, feel free to reach out to [@MansoorAZafar](https://github.com/MansoorAZafar).

---

Thank you for playing Card Clash! Your feedback is invaluable in making the game better. Enjoy your adventure!

