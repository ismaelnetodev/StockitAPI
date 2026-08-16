import { Text, View } from 'react-native';

import { Button, ButtonText } from '@/components/ui/button';

export default function Index() {
  return (
    <View className="flex-1 items-center justify-center gap-4 bg-background">
      <Text className="text-xl font-bold text-foreground">Olá Mundo!</Text>
      <Button variant="default" size="default">
        <ButtonText>Clique de exemplo</ButtonText>
      </Button>
    </View>
  );
}
