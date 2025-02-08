# Buff GitHub Viewer

Buff GitHub Viewer is a lightweight console application that retrieves and displays the number of profile views from a GitHub profile view counter badge in real-time.

## Features
- **Custom URL Input**: Users can manually enter the profile view counter URL.
- **Automated Requests**: Continuously sends HTTP requests to update the profile view count.
- **Real-Time Extraction**: Uses regex to extract numbers from the response (supports both formatted and unformatted numbers).
- **Looped Execution**: Runs indefinitely with a delay to avoid excessive requests.
- **Lightweight & Efficient**: Uses minimal resources while ensuring smooth operation.

## How to Use
### Step 1: Get the Profile View Counter URL
1. Go to your GitHub profile where you have the profile views badge.
2. **Click on the "Profile views" text** on the badge.
3. Copy the **image URL** from the new tab that opens.

### Step 2: Run the Application
1. Open the **Buff GitHub Viewer** tool.
2. Paste the copied **URL** into the console and press **Enter**.
3. The tool will display and update the number of profile views in real-time.

## Example
```
Enter URL of profile: https://camo.githubusercontent.com/...
Profile view: 123,456
Profile view: 123,457
Profile view: 123,458
...
```

## Notes
- Ensure you have an active internet connection for continuous updates.
- The number format may vary depending on the response from GitHub.

## License
This project is for educational and personal use only.

