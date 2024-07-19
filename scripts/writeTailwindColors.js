import fs from "node:fs";
import resolveConfig from "tailwindcss/resolveConfig.js";

const fullConfig = resolveConfig({});

fs.writeFileSync(
  "./src/Kethan.DevToys.Tailwind.ClosestColor/tailwind-colors.json",
  JSON.stringify(fullConfig.theme.colors, null, 4)
);
