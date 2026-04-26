# CRTP-Singleton
Simple curiously recurring template pattern (CRTP) where you have a singleton monobehaviour class you inherit from.

## How is this used?
- Instead of implementing a singleton everytime for each specific class you can inherit it from the CRTP by having your new class as the parameter.
- So instead of having for example: public class WeaponClass : Monobehaviour then creating a singleton you simply do: public class WeaponClass : CRTPSingleton<WeaponClass> and it will automatically have a WeaponClass.instance
