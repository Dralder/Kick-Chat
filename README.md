# Kick Chat

Just a simple, lightweight overlay application designed to let you see your stream chat while playing games—highly useful for streamers managing their broadcast with a single monitor!

> [!IMPORTANT]
> To ensure the chat window overlays correctly on top of your game, you **must** change your game's display settings to **Borderless** or **Windowed Fullscreen**. It will not overlay on games running in exclusive fullscreen mode.

---

## Key Features

* **Dual-Platform Chat Support:** Integrated chat overlay for **Kick** and **Twitch** usernames simultaneously.
* **Custom Live Alerts:** Automatically broadcasts customized live notifications to **Discord** (via webhooks) and **Telegram** (via bot token) immediately upon detecting your broadcast status.
* **OBS Studio Integration:** Native connection to OBS WebSocket to track system connection status and control live event pipelines dynamically.
* **Stream Customization:** Full UI control modifying background opacity, borders, custom fonts, typography sizes, animations, and text strokes.
* Thanks to **Corard** for providing the underlying chat engine API service (https://kick-chat.corard.tv/).

---

## OBS Connection Status Indicator

In the alerts window, the OBS text shows that color tracking the diagnostic health state of your OBS WebSocket interface. Refer to the table below to interpret current states:

| Status Color | Meaning |
| :--- | :--- |
| 🟡 **Yellow** | **Connecting / Reconnecting:** The application is currently handshaking or attempting a connection to your specified OBS port. |
| 🟢 **Green** | **Connected:** Safely established communication with your OBS WebSocket. Systems are online (even when you are not actively streaming or recording). |
| 🔴 **Red** | **Connection Failed / Error:** The port location might be blocked, credentials mismatch, or the OBS server rejected the connection protocol entirely. |

---

## Configuration & Setup

### 1. Chat Setup
* Enter your **Kick Username** directly into the interface.
* If streaming on both platforms, toggle the **Twitch Checkbox** and enter your **Twitch Username** to display integrated messages side-by-side inside the overlay link structure.

### 2. OBS Automation Setup
1. Enable **WebSockets Server** inside OBS Studio via *Tools* -> *WebSocket Server Settings*.
2. Note your configured **Server Port** and **Server Password**.
3. Input the Host (`localhost` or local IP), Port, and Password into the app panels to automatically initiate real-time streaming state checks.

### 3. Automated Alerts Setup
* **Telegram Configuration:** Input your created Telegram Bot API Token along with your target destination Channel/Chat ID parameters.
* **Discord Configuration:** Paste your unique channel Integration Webhook URL parameter to instantly feed rich markdown embeds containing custom text and optional media attachments when the broadcast begins.
* **Testing Alerts:** Starting a **Recording** in OBS sends out live alert updates identically to starting a stream, allowing you to thoroughly test your webhooks and bot integrations layout before going live.
* 
---

## Feedback & Support

If you have any suggestions or issues let me know on discord: **@Dralder**
