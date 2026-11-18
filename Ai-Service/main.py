from fastapi import FastAPI
from google import genai

app = FastAPI()
client = genai.Client(api_key="YOUR_GEMINI_API_KEY_HERE")

@app.get("/ask")
def ask(question: str):
    reply = client.models.generate_content(
        model="gemini-3.5-flash",
        contents=question
    )
    return {"answer": reply.text}