\
\ @file exti.fs
\ @brief EXTI address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] EXTI_DEF

  [ifdef] EXTI_EXTI_RTSR1_DEF
    \
    \ @brief EXTI rising trigger selection register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RT0                       \ [0x00] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $01 constant EXTI_RT1                       \ [0x01] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $02 constant EXTI_RT2                       \ [0x02] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $03 constant EXTI_RT3                       \ [0x03] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $04 constant EXTI_RT4                       \ [0x04] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $05 constant EXTI_RT5                       \ [0x05] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $06 constant EXTI_RT6                       \ [0x06] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $07 constant EXTI_RT7                       \ [0x07] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $08 constant EXTI_RT8                       \ [0x08] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $09 constant EXTI_RT9                       \ [0x09] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $0a constant EXTI_RT10                      \ [0x0a] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $0b constant EXTI_RT11                      \ [0x0b] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $0c constant EXTI_RT12                      \ [0x0c] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $0d constant EXTI_RT13                      \ [0x0d] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $0e constant EXTI_RT14                      \ [0x0e] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
    $0f constant EXTI_RT15                      \ [0x0f] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
  [then]


  [ifdef] EXTI_EXTI_FTSR1_DEF
    \
    \ @brief EXTI falling trigger selection register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FT0                       \ [0x00] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $01 constant EXTI_FT1                       \ [0x01] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $02 constant EXTI_FT2                       \ [0x02] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $03 constant EXTI_FT3                       \ [0x03] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $04 constant EXTI_FT4                       \ [0x04] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $05 constant EXTI_FT5                       \ [0x05] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $06 constant EXTI_FT6                       \ [0x06] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $07 constant EXTI_FT7                       \ [0x07] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $08 constant EXTI_FT8                       \ [0x08] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $09 constant EXTI_FT9                       \ [0x09] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $0a constant EXTI_FT10                      \ [0x0a] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $0b constant EXTI_FT11                      \ [0x0b] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $0c constant EXTI_FT12                      \ [0x0c] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $0d constant EXTI_FT13                      \ [0x0d] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $0e constant EXTI_FT14                      \ [0x0e] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
    $0f constant EXTI_FT15                      \ [0x0f] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
  [then]


  [ifdef] EXTI_EXTI_SWIER1_DEF
    \
    \ @brief EXTI software interrupt event register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWI0                      \ [0x00] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $01 constant EXTI_SWI1                      \ [0x01] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $02 constant EXTI_SWI2                      \ [0x02] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $03 constant EXTI_SWI3                      \ [0x03] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $04 constant EXTI_SWI4                      \ [0x04] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $05 constant EXTI_SWI5                      \ [0x05] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $06 constant EXTI_SWI6                      \ [0x06] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $07 constant EXTI_SWI7                      \ [0x07] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $08 constant EXTI_SWI8                      \ [0x08] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $09 constant EXTI_SWI9                      \ [0x09] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0a constant EXTI_SWI10                     \ [0x0a] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0b constant EXTI_SWI11                     \ [0x0b] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0c constant EXTI_SWI12                     \ [0x0c] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0d constant EXTI_SWI13                     \ [0x0d] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0e constant EXTI_SWI14                     \ [0x0e] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0f constant EXTI_SWI15                     \ [0x0f] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
  [then]


  [ifdef] EXTI_EXTI_RPR1_DEF
    \
    \ @brief EXTI rising edge pending register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RPIF0                     \ [0x00] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $01 constant EXTI_RPIF1                     \ [0x01] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $02 constant EXTI_RPIF2                     \ [0x02] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $03 constant EXTI_RPIF3                     \ [0x03] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $04 constant EXTI_RPIF4                     \ [0x04] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $05 constant EXTI_RPIF5                     \ [0x05] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $06 constant EXTI_RPIF6                     \ [0x06] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $07 constant EXTI_RPIF7                     \ [0x07] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $08 constant EXTI_RPIF8                     \ [0x08] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $09 constant EXTI_RPIF9                     \ [0x09] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0a constant EXTI_RPIF10                    \ [0x0a] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0b constant EXTI_RPIF11                    \ [0x0b] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0c constant EXTI_RPIF12                    \ [0x0c] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0d constant EXTI_RPIF13                    \ [0x0d] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0e constant EXTI_RPIF14                    \ [0x0e] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0f constant EXTI_RPIF15                    \ [0x0f] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
  [then]


  [ifdef] EXTI_EXTI_FPR1_DEF
    \
    \ @brief EXTI falling edge pending register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FPIF0                     \ [0x00] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $01 constant EXTI_FPIF1                     \ [0x01] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $02 constant EXTI_FPIF2                     \ [0x02] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $03 constant EXTI_FPIF3                     \ [0x03] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $04 constant EXTI_FPIF4                     \ [0x04] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $05 constant EXTI_FPIF5                     \ [0x05] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $06 constant EXTI_FPIF6                     \ [0x06] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $07 constant EXTI_FPIF7                     \ [0x07] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $08 constant EXTI_FPIF8                     \ [0x08] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $09 constant EXTI_FPIF9                     \ [0x09] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0a constant EXTI_FPIF10                    \ [0x0a] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0b constant EXTI_FPIF11                    \ [0x0b] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0c constant EXTI_FPIF12                    \ [0x0c] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0d constant EXTI_FPIF13                    \ [0x0d] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0e constant EXTI_FPIF14                    \ [0x0e] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0f constant EXTI_FPIF15                    \ [0x0f] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
  [then]


  [ifdef] EXTI_EXTI_RTSR2_DEF
    \
    \ @brief EXTI rising trigger selection register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_RT34                      \ [0x02] Rising trigger event configuration bit of configurable line 34 Each bit enables/disables the rising edge trigger for the event and interrupt on the line 34. This configurable line is edge triggered; no glitch must be generated on this inputs. Note: If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
  [then]


  [ifdef] EXTI_EXTI_FTSR2_DEF
    \
    \ @brief EXTI falling trigger selection register 2
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_FT34                      \ [0x02] Falling trigger event configuration bit of configurable line 34. Each bit enables/disables the falling edge trigger for the event and interrupt on the line 34. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
  [then]


  [ifdef] EXTI_EXTI_SWIER2_DEF
    \
    \ @brief EXTI software interrupt event register 2
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_SWI34                     \ [0x02] Software rising edge event trigger on line 34 Setting of any bit by software triggers a rising edge event on the line 34, resulting in an interrupt, independently of EXTI_RTSR2 and EXTI_FTSR2 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
  [then]


  [ifdef] EXTI_EXTI_RPR2_DEF
    \
    \ @brief EXTI rising edge pending register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_RPIF34                    \ [0x02] Rising edge event pending for configurable line 34 Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER2 register) on the line 34. Each bit is cleared by writing 1 into it.
  [then]


  [ifdef] EXTI_EXTI_FPR2_DEF
    \
    \ @brief EXTI falling edge pending register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_FPIF34                    \ [0x02] Falling edge event pending for configurable line 34 Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER2 register) on the line 34. Each bit is cleared by writing 1 into it.
  [then]


  [ifdef] EXTI_EXTI_EXTICR1_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0                     \ [0x00 : 8] EXTI0 GPIO port selection These bits are written by software to select the source input for EXTI0 external interrupt. Others reserved
    $08 constant EXTI_EXTI1                     \ [0x08 : 8] EXTI1 GPIO port selection These bits are written by software to select the source input for EXTI1 external interrupt. Others reserved
    $10 constant EXTI_EXTI2                     \ [0x10 : 8] EXTI2 GPIO port selection These bits are written by software to select the source input for EXTI2 external interrupt. Others reserved
    $18 constant EXTI_EXTI3                     \ [0x18 : 8] EXTI3 GPIO port selection These bits are written by software to select the source input for EXTI3 external interrupt. Others reserved
  [then]


  [ifdef] EXTI_EXTI_EXTICR2_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI4                     \ [0x00 : 8] EXTI4 GPIO port selection These bits are written by software to select the source input for EXTI4 external interrupt. Others reserved
    $08 constant EXTI_EXTI5                     \ [0x08 : 8] EXTI5 GPIO port selection These bits are written by software to select the source input for EXTI5 external interrupt. Others reserved
    $10 constant EXTI_EXTI6                     \ [0x10 : 8] EXTI6 GPIO port selection These bits are written by software to select the source input for EXTI6 external interrupt. Others reserved
    $18 constant EXTI_EXTI7                     \ [0x18 : 8] EXTI7 GPIO port selection These bits are written by software to select the source input for EXTI7 external interrupt. Others reserved
  [then]


  [ifdef] EXTI_EXTI_EXTICR3_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI8                     \ [0x00 : 8] EXTI8 GPIO port selection These bits are written by software to select the source input for EXTI8 external interrupt. Others reserved
    $08 constant EXTI_EXTI9                     \ [0x08 : 8] EXTI9 GPIO port selection These bits are written by software to select the source input for EXTI9 external interrupt. Others reserved
    $10 constant EXTI_EXTI10                    \ [0x10 : 8] EXTI10 GPIO port selection These bits are written by software to select the source input for EXTI10 external interrupt. Others reserved
    $18 constant EXTI_EXTI11                    \ [0x18 : 8] EXTI11 GPIO port selection These bits are written by software to select the source input for EXTI11 external interrupt. Others reserved
  [then]


  [ifdef] EXTI_EXTI_EXTICR4_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI12                    \ [0x00 : 8] EXTI12 GPIO port selection These bits are written by software to select the source input for EXTI12 external interrupt. Others reserved
    $08 constant EXTI_EXTI13                    \ [0x08 : 8] EXTI13 GPIO port selection These bits are written by software to select the source input for EXTI13 external interrupt. Others reserved
    $10 constant EXTI_EXTI14                    \ [0x10 : 8] EXTI14 GPIO port selection These bits are written by software to select the source input for EXTI14 external interrupt. Others reserved
    $18 constant EXTI_EXTI15                    \ [0x18 : 8] EXTI15 GPIO port selection These bits are written by software to select the source input for EXTI15 external interrupt. Others reserved
  [then]


  [ifdef] EXTI_EXTI_IMR1_DEF
    \
    \ @brief EXTI CPU wakeup with interrupt mask register 1
    \ Address offset: 0x80
    \ Reset value: 0xFFF80000
    \
    $00 constant EXTI_IM0                       \ [0x00] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $01 constant EXTI_IM1                       \ [0x01] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $02 constant EXTI_IM2                       \ [0x02] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $03 constant EXTI_IM3                       \ [0x03] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $04 constant EXTI_IM4                       \ [0x04] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $05 constant EXTI_IM5                       \ [0x05] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $06 constant EXTI_IM6                       \ [0x06] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $07 constant EXTI_IM7                       \ [0x07] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $08 constant EXTI_IM8                       \ [0x08] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $09 constant EXTI_IM9                       \ [0x09] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $0a constant EXTI_IM10                      \ [0x0a] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $0b constant EXTI_IM11                      \ [0x0b] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $0c constant EXTI_IM12                      \ [0x0c] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $0d constant EXTI_IM13                      \ [0x0d] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $0e constant EXTI_IM14                      \ [0x0e] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $0f constant EXTI_IM15                      \ [0x0f] CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $13 constant EXTI_IM19                      \ [0x13] CPU wakeup with interrupt mask on line 19 Setting/clearing this bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $17 constant EXTI_IM23                      \ [0x17] CPU wakeup with interrupt mask on line 23 Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $19 constant EXTI_IM25                      \ [0x19] CPU wakeup with interrupt mask on line 25 Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
    $1f constant EXTI_IM31                      \ [0x1f] CPU wakeup with interrupt mask on line 31 Setting/clearing this bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
  [then]


  [ifdef] EXTI_EXTI_EMR1_DEF
    \
    \ @brief EXTI CPU wakeup with event mask register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0                       \ [0x00] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $01 constant EXTI_EM1                       \ [0x01] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $02 constant EXTI_EM2                       \ [0x02] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $03 constant EXTI_EM3                       \ [0x03] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $04 constant EXTI_EM4                       \ [0x04] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $05 constant EXTI_EM5                       \ [0x05] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $06 constant EXTI_EM6                       \ [0x06] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $07 constant EXTI_EM7                       \ [0x07] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $08 constant EXTI_EM8                       \ [0x08] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $09 constant EXTI_EM9                       \ [0x09] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $0a constant EXTI_EM10                      \ [0x0a] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $0b constant EXTI_EM11                      \ [0x0b] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $0c constant EXTI_EM12                      \ [0x0c] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $0d constant EXTI_EM13                      \ [0x0d] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $0e constant EXTI_EM14                      \ [0x0e] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $0f constant EXTI_EM15                      \ [0x0f] CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $13 constant EXTI_EM19                      \ [0x13] CPU wakeup with event generation mask on line 19 Setting/clearing this bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $17 constant EXTI_EM23                      \ [0x17] CPU wakeup with event generation mask on line 23 Setting/clearing this bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $19 constant EXTI_EM25                      \ [0x19] CPU wakeup with event generation mask on line 25 Setting/clearing this bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
    $1f constant EXTI_EM31                      \ [0x1f] CPU wakeup with event generation mask on line 31 Setting/clearing this bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
  [then]


  [ifdef] EXTI_EXTI_IMR2_DEF
    \
    \ @brief EXTI CPU wakeup with interrupt mask register 2
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_IM34                      \ [0x02] CPU wakeup with interrupt mask on line 34 Setting/clearing the bit unmasks/masks the CPU wakeup with interrupt request from the line 34.
    $04 constant EXTI_IM36                      \ [0x04] CPU wake-up with interrupt mask on line 36
  [then]


  [ifdef] EXTI_EXTI_EMR2_DEF
    \
    \ @brief EXTI CPU wakeup with event mask register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_EM34                      \ [0x02] CPU wakeup with event generation mask on line 34 Setting/clearing this bit unmasks/masks the CPU wakeup with event generation on the line 34.
    $04 constant EXTI_EM36                      \ [0x04] CPU wake-up with event generation mask on line 36
  [then]

  \
  \ @brief EXTI address block description
  \
  $00 constant EXTI_EXTI_RTSR1          \ EXTI rising trigger selection register 1
  $04 constant EXTI_EXTI_FTSR1          \ EXTI falling trigger selection register 1
  $08 constant EXTI_EXTI_SWIER1         \ EXTI software interrupt event register 1
  $0C constant EXTI_EXTI_RPR1           \ EXTI rising edge pending register 1
  $10 constant EXTI_EXTI_FPR1           \ EXTI falling edge pending register 1
  $28 constant EXTI_EXTI_RTSR2          \ EXTI rising trigger selection register 2
  $2C constant EXTI_EXTI_FTSR2          \ EXTI falling trigger selection register 2
  $30 constant EXTI_EXTI_SWIER2         \ EXTI software interrupt event register 2
  $34 constant EXTI_EXTI_RPR2           \ EXTI rising edge pending register 2
  $38 constant EXTI_EXTI_FPR2           \ EXTI falling edge pending register 2
  $60 constant EXTI_EXTI_EXTICR1        \ EXTI external interrupt selection register
  $64 constant EXTI_EXTI_EXTICR2        \ EXTI external interrupt selection register
  $68 constant EXTI_EXTI_EXTICR3        \ EXTI external interrupt selection register
  $6C constant EXTI_EXTI_EXTICR4        \ EXTI external interrupt selection register
  $80 constant EXTI_EXTI_IMR1           \ EXTI CPU wakeup with interrupt mask register 1
  $84 constant EXTI_EXTI_EMR1           \ EXTI CPU wakeup with event mask register
  $90 constant EXTI_EXTI_IMR2           \ EXTI CPU wakeup with interrupt mask register 2
  $94 constant EXTI_EXTI_EMR2           \ EXTI CPU wakeup with event mask register 2

: EXTI_DEF ; [then]
