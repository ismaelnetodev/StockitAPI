# Stockit — frontend

App Expo (SDK 57) com expo-router e NativeWind v4.

## Rodar

```bash
npm install
npx expo start
```

## Estrutura

- `src/app/` — rotas do expo-router (file-based routing)
- `src/global.css` — entrada do Tailwind, importada em `src/app/_layout.tsx`
- `tailwind.config.js` — content aponta para `./src/**/*.{js,jsx,ts,tsx}`
- `metro.config.js` — `withNativeWind(config, { input: './src/global.css' })`

O alias `@/*` aponta para `./src/*`.
