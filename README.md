# 👻 Horror Escape - A Mini 3D Horror Game (Observer Pattern)

**Horror Escape** is a short 3D horror game prototype built in Unity to practically implement and explore the **Observer Pattern** in game development.  
The player must collect keys to escape a haunted house filled with creepy surprises and dynamically triggered horror events.

---

## 🧠 What I Learned

- ✅ Real-world implementation of the **Observer Pattern** in Unity.
- ✅ How to build a **decoupled event system** using `delegate`, `Action`, and `event`.
- ✅ Increased scalability and modularity by removing direct dependencies between game systems.
- ✅ Improved flexibility in how multiple gameplay events are triggered and managed.

---

## 🕹️ Gameplay Highlights

- 🔑 **Key Collection Triggers**: Certain key pickups trigger horror events.
- 💡 **Lights Out Event**: Mysterious power cuts leave the player in darkness.
- 🐀 **Rat Rush**: A sudden stampede of rats charges toward the player.
- 💀 **Skeleton Drop**: Bones rain down from above, adding a creepy layer of tension.
  
All events are **dynamically triggered** using a custom **Observer-based event system**.

---

## 🛠️ What I Built

- ⚙️ A **reusable Observer-based Event System** that broadcasts events across the game.
- 🎯 Multiple horror triggers wired through **Action/event** delegates — **no tight coupling**.
- 🧩 Flexible architecture that allows additional events or systems to subscribe independently.

---

## 💡 Core Concept: Observer Pattern in Unity

Instead of hard-coding relationships between classes, I used:

- `public static event Action OnKeyCollected;`  
- `EventManager.Trigger(EventType.KeyCollected);`  
- Subscribing systems like `LightOutEvent` or `RatRushEvent` respond **only when needed**.

This allows:
- Easy **add/remove** of listeners.
- **Clean separation** between game systems.
- Much **easier debugging and iteration** on events.

---

## 📚 Key Takeaways 

- ✅ Great exercise for mastering the **Observer Pattern** in a game development setting.
- ✅ Gained confidence in **building scalable systems** with clean, maintainable architecture.
