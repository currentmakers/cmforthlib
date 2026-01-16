\
\ @file exti.fs
\ @brief EXTI address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief EXTI rising trigger selection register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_RTSR1_RT0                              \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00000002 constant EXTI_EXTI_RTSR1_RT1                              \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00000004 constant EXTI_EXTI_RTSR1_RT2                              \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00000008 constant EXTI_EXTI_RTSR1_RT3                              \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00000010 constant EXTI_EXTI_RTSR1_RT4                              \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00000020 constant EXTI_EXTI_RTSR1_RT5                              \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00000040 constant EXTI_EXTI_RTSR1_RT6                              \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00000080 constant EXTI_EXTI_RTSR1_RT7                              \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00000100 constant EXTI_EXTI_RTSR1_RT8                              \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00000200 constant EXTI_EXTI_RTSR1_RT9                              \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00000400 constant EXTI_EXTI_RTSR1_RT10                             \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00000800 constant EXTI_EXTI_RTSR1_RT11                             \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00001000 constant EXTI_EXTI_RTSR1_RT12                             \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00002000 constant EXTI_EXTI_RTSR1_RT13                             \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00004000 constant EXTI_EXTI_RTSR1_RT14                             \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.
$00008000 constant EXTI_EXTI_RTSR1_RT15                             \ Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line. Note: The configurable lines are edge triggered; no glitch must be generated on these inputs. If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.


\
\ @brief EXTI falling trigger selection register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_FTSR1_FT0                              \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00000002 constant EXTI_EXTI_FTSR1_FT1                              \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00000004 constant EXTI_EXTI_FTSR1_FT2                              \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00000008 constant EXTI_EXTI_FTSR1_FT3                              \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00000010 constant EXTI_EXTI_FTSR1_FT4                              \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00000020 constant EXTI_EXTI_FTSR1_FT5                              \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00000040 constant EXTI_EXTI_FTSR1_FT6                              \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00000080 constant EXTI_EXTI_FTSR1_FT7                              \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00000100 constant EXTI_EXTI_FTSR1_FT8                              \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00000200 constant EXTI_EXTI_FTSR1_FT9                              \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00000400 constant EXTI_EXTI_FTSR1_FT10                             \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00000800 constant EXTI_EXTI_FTSR1_FT11                             \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00001000 constant EXTI_EXTI_FTSR1_FT12                             \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00002000 constant EXTI_EXTI_FTSR1_FT13                             \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00004000 constant EXTI_EXTI_FTSR1_FT14                             \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.
$00008000 constant EXTI_EXTI_FTSR1_FT15                             \ Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.


\
\ @brief EXTI software interrupt event register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_SWIER1_SWI0                            \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00000002 constant EXTI_EXTI_SWIER1_SWI1                            \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00000004 constant EXTI_EXTI_SWIER1_SWI2                            \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00000008 constant EXTI_EXTI_SWIER1_SWI3                            \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00000010 constant EXTI_EXTI_SWIER1_SWI4                            \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00000020 constant EXTI_EXTI_SWIER1_SWI5                            \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00000040 constant EXTI_EXTI_SWIER1_SWI6                            \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00000080 constant EXTI_EXTI_SWIER1_SWI7                            \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00000100 constant EXTI_EXTI_SWIER1_SWI8                            \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00000200 constant EXTI_EXTI_SWIER1_SWI9                            \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00000400 constant EXTI_EXTI_SWIER1_SWI10                           \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00000800 constant EXTI_EXTI_SWIER1_SWI11                           \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00001000 constant EXTI_EXTI_SWIER1_SWI12                           \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00002000 constant EXTI_EXTI_SWIER1_SWI13                           \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00004000 constant EXTI_EXTI_SWIER1_SWI14                           \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
$00008000 constant EXTI_EXTI_SWIER1_SWI15                           \ Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.


\
\ @brief EXTI rising edge pending register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_RPR1_RPIF0                             \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000002 constant EXTI_EXTI_RPR1_RPIF1                             \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000004 constant EXTI_EXTI_RPR1_RPIF2                             \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000008 constant EXTI_EXTI_RPR1_RPIF3                             \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000010 constant EXTI_EXTI_RPR1_RPIF4                             \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000020 constant EXTI_EXTI_RPR1_RPIF5                             \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000040 constant EXTI_EXTI_RPR1_RPIF6                             \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000080 constant EXTI_EXTI_RPR1_RPIF7                             \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000100 constant EXTI_EXTI_RPR1_RPIF8                             \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000200 constant EXTI_EXTI_RPR1_RPIF9                             \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000400 constant EXTI_EXTI_RPR1_RPIF10                            \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000800 constant EXTI_EXTI_RPR1_RPIF11                            \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00001000 constant EXTI_EXTI_RPR1_RPIF12                            \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00002000 constant EXTI_EXTI_RPR1_RPIF13                            \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00004000 constant EXTI_EXTI_RPR1_RPIF14                            \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00008000 constant EXTI_EXTI_RPR1_RPIF15                            \ Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.


\
\ @brief EXTI falling edge pending register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_FPR1_FPIF0                             \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000002 constant EXTI_EXTI_FPR1_FPIF1                             \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000004 constant EXTI_EXTI_FPR1_FPIF2                             \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000008 constant EXTI_EXTI_FPR1_FPIF3                             \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000010 constant EXTI_EXTI_FPR1_FPIF4                             \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000020 constant EXTI_EXTI_FPR1_FPIF5                             \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000040 constant EXTI_EXTI_FPR1_FPIF6                             \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000080 constant EXTI_EXTI_FPR1_FPIF7                             \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000100 constant EXTI_EXTI_FPR1_FPIF8                             \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000200 constant EXTI_EXTI_FPR1_FPIF9                             \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000400 constant EXTI_EXTI_FPR1_FPIF10                            \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00000800 constant EXTI_EXTI_FPR1_FPIF11                            \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00001000 constant EXTI_EXTI_FPR1_FPIF12                            \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00002000 constant EXTI_EXTI_FPR1_FPIF13                            \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00004000 constant EXTI_EXTI_FPR1_FPIF14                            \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
$00008000 constant EXTI_EXTI_FPR1_FPIF15                            \ Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.


\
\ @brief EXTI rising trigger selection register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_RTSR2_RT34                             \ Rising trigger event configuration bit of configurable line 34 Each bit enables/disables the rising edge trigger for the event and interrupt on the line 34. This configurable line is edge triggered; no glitch must be generated on this inputs. Note: If a rising edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Rising edge trigger can be set for a line with falling edge trigger enabled. In this case, both edges generate a trigger.


\
\ @brief EXTI falling trigger selection register 2
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_FTSR2_FT34                             \ Falling trigger event configuration bit of configurable line 34. Each bit enables/disables the falling edge trigger for the event and interrupt on the line 34. The configurable lines are edge triggered; no glitch must be generated on these inputs. Note: If a falling edge on the configurable line occurs during writing of the register, the associated pending bit is not set. Falling edge trigger can be set for a line with rising edge trigger enabled. In this case, both edges generate a trigger.


\
\ @brief EXTI software interrupt event register 2
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_SWIER2_SWI34                           \ Software rising edge event trigger on line 34 Setting of any bit by software triggers a rising edge event on the line 34, resulting in an interrupt, independently of EXTI_RTSR2 and EXTI_FTSR2 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.


\
\ @brief EXTI rising edge pending register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_RPR2_RPIF34                            \ Rising edge event pending for configurable line 34 Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER2 register) on the line 34. Each bit is cleared by writing 1 into it.


\
\ @brief EXTI falling edge pending register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_FPR2_FPIF34                            \ Falling edge event pending for configurable line 34 Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER2 register) on the line 34. Each bit is cleared by writing 1 into it.


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR1_EXTI0                          \ EXTI0 GPIO port selection These bits are written by software to select the source input for EXTI0 external interrupt. Others reserved
$0000ff00 constant EXTI_EXTI_EXTICR1_EXTI1                          \ EXTI1 GPIO port selection These bits are written by software to select the source input for EXTI1 external interrupt. Others reserved
$00ff0000 constant EXTI_EXTI_EXTICR1_EXTI2                          \ EXTI2 GPIO port selection These bits are written by software to select the source input for EXTI2 external interrupt. Others reserved
$ff000000 constant EXTI_EXTI_EXTICR1_EXTI3                          \ EXTI3 GPIO port selection These bits are written by software to select the source input for EXTI3 external interrupt. Others reserved


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR2_EXTI4                          \ EXTI4 GPIO port selection These bits are written by software to select the source input for EXTI4 external interrupt. Others reserved
$0000ff00 constant EXTI_EXTI_EXTICR2_EXTI5                          \ EXTI5 GPIO port selection These bits are written by software to select the source input for EXTI5 external interrupt. Others reserved
$00ff0000 constant EXTI_EXTI_EXTICR2_EXTI6                          \ EXTI6 GPIO port selection These bits are written by software to select the source input for EXTI6 external interrupt. Others reserved
$ff000000 constant EXTI_EXTI_EXTICR2_EXTI7                          \ EXTI7 GPIO port selection These bits are written by software to select the source input for EXTI7 external interrupt. Others reserved


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR3_EXTI8                          \ EXTI8 GPIO port selection These bits are written by software to select the source input for EXTI8 external interrupt. Others reserved
$0000ff00 constant EXTI_EXTI_EXTICR3_EXTI9                          \ EXTI9 GPIO port selection These bits are written by software to select the source input for EXTI9 external interrupt. Others reserved
$00ff0000 constant EXTI_EXTI_EXTICR3_EXTI10                         \ EXTI10 GPIO port selection These bits are written by software to select the source input for EXTI10 external interrupt. Others reserved
$ff000000 constant EXTI_EXTI_EXTICR3_EXTI11                         \ EXTI11 GPIO port selection These bits are written by software to select the source input for EXTI11 external interrupt. Others reserved


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR4_EXTI12                         \ EXTI12 GPIO port selection These bits are written by software to select the source input for EXTI12 external interrupt. Others reserved
$0000ff00 constant EXTI_EXTI_EXTICR4_EXTI13                         \ EXTI13 GPIO port selection These bits are written by software to select the source input for EXTI13 external interrupt. Others reserved
$00ff0000 constant EXTI_EXTI_EXTICR4_EXTI14                         \ EXTI14 GPIO port selection These bits are written by software to select the source input for EXTI14 external interrupt. Others reserved
$ff000000 constant EXTI_EXTI_EXTICR4_EXTI15                         \ EXTI15 GPIO port selection These bits are written by software to select the source input for EXTI15 external interrupt. Others reserved


\
\ @brief EXTI CPU wakeup with interrupt mask register 1
\ Address offset: 0x80
\ Reset value: 0xFFF80000
\

$00000001 constant EXTI_EXTI_IMR1_IM0                               \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00000002 constant EXTI_EXTI_IMR1_IM1                               \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00000004 constant EXTI_EXTI_IMR1_IM2                               \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00000008 constant EXTI_EXTI_IMR1_IM3                               \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00000010 constant EXTI_EXTI_IMR1_IM4                               \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00000020 constant EXTI_EXTI_IMR1_IM5                               \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00000040 constant EXTI_EXTI_IMR1_IM6                               \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00000080 constant EXTI_EXTI_IMR1_IM7                               \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00000100 constant EXTI_EXTI_IMR1_IM8                               \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00000200 constant EXTI_EXTI_IMR1_IM9                               \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00000400 constant EXTI_EXTI_IMR1_IM10                              \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00000800 constant EXTI_EXTI_IMR1_IM11                              \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00001000 constant EXTI_EXTI_IMR1_IM12                              \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00002000 constant EXTI_EXTI_IMR1_IM13                              \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00004000 constant EXTI_EXTI_IMR1_IM14                              \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00008000 constant EXTI_EXTI_IMR1_IM15                              \ CPU wakeup with interrupt mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00080000 constant EXTI_EXTI_IMR1_IM19                              \ CPU wakeup with interrupt mask on line 19 Setting/clearing this bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$00800000 constant EXTI_EXTI_IMR1_IM23                              \ CPU wakeup with interrupt mask on line 23 Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$02000000 constant EXTI_EXTI_IMR1_IM25                              \ CPU wakeup with interrupt mask on line 25 Setting/clearing each bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.
$80000000 constant EXTI_EXTI_IMR1_IM31                              \ CPU wakeup with interrupt mask on line 31 Setting/clearing this bit unmasks/masks the CPU wakeup with interrupt, by an event on the corresponding line.


\
\ @brief EXTI CPU wakeup with event mask register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_EMR1_EM0                               \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00000002 constant EXTI_EXTI_EMR1_EM1                               \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00000004 constant EXTI_EXTI_EMR1_EM2                               \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00000008 constant EXTI_EXTI_EMR1_EM3                               \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00000010 constant EXTI_EXTI_EMR1_EM4                               \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00000020 constant EXTI_EXTI_EMR1_EM5                               \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00000040 constant EXTI_EXTI_EMR1_EM6                               \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00000080 constant EXTI_EXTI_EMR1_EM7                               \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00000100 constant EXTI_EXTI_EMR1_EM8                               \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00000200 constant EXTI_EXTI_EMR1_EM9                               \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00000400 constant EXTI_EXTI_EMR1_EM10                              \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00000800 constant EXTI_EXTI_EMR1_EM11                              \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00001000 constant EXTI_EXTI_EMR1_EM12                              \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00002000 constant EXTI_EXTI_EMR1_EM13                              \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00004000 constant EXTI_EXTI_EMR1_EM14                              \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00008000 constant EXTI_EXTI_EMR1_EM15                              \ CPU wakeup with event generation mask on line x (x = 15 to 0) Setting/clearing each bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00080000 constant EXTI_EXTI_EMR1_EM19                              \ CPU wakeup with event generation mask on line 19 Setting/clearing this bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$00800000 constant EXTI_EXTI_EMR1_EM23                              \ CPU wakeup with event generation mask on line 23 Setting/clearing this bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$02000000 constant EXTI_EXTI_EMR1_EM25                              \ CPU wakeup with event generation mask on line 25 Setting/clearing this bit unmasks/masks the CPU wakeup with event generation on the corresponding line.
$80000000 constant EXTI_EXTI_EMR1_EM31                              \ CPU wakeup with event generation mask on line 31 Setting/clearing this bit unmasks/masks the CPU wakeup with event generation on the corresponding line.


\
\ @brief EXTI CPU wakeup with interrupt mask register 2
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_IMR2_IM34                              \ CPU wakeup with interrupt mask on line 34 Setting/clearing the bit unmasks/masks the CPU wakeup with interrupt request from the line 34.
$00000010 constant EXTI_EXTI_IMR2_IM36                              \ CPU wake-up with interrupt mask on line 36


\
\ @brief EXTI CPU wakeup with event mask register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_EMR2_EM34                              \ CPU wakeup with event generation mask on line 34 Setting/clearing this bit unmasks/masks the CPU wakeup with event generation on the line 34.
$00000010 constant EXTI_EXTI_EMR2_EM36                              \ CPU wake-up with event generation mask on line 36


\
\ @brief EXTI address block description
\
$40021800 constant EXTI_EXTI_RTSR1  \ offset: 0x00 : EXTI rising trigger selection register 1
$40021804 constant EXTI_EXTI_FTSR1  \ offset: 0x04 : EXTI falling trigger selection register 1
$40021808 constant EXTI_EXTI_SWIER1  \ offset: 0x08 : EXTI software interrupt event register 1
$4002180c constant EXTI_EXTI_RPR1  \ offset: 0x0C : EXTI rising edge pending register 1
$40021810 constant EXTI_EXTI_FPR1  \ offset: 0x10 : EXTI falling edge pending register 1
$40021828 constant EXTI_EXTI_RTSR2  \ offset: 0x28 : EXTI rising trigger selection register 2
$4002182c constant EXTI_EXTI_FTSR2  \ offset: 0x2C : EXTI falling trigger selection register 2
$40021830 constant EXTI_EXTI_SWIER2  \ offset: 0x30 : EXTI software interrupt event register 2
$40021834 constant EXTI_EXTI_RPR2  \ offset: 0x34 : EXTI rising edge pending register 2
$40021838 constant EXTI_EXTI_FPR2  \ offset: 0x38 : EXTI falling edge pending register 2
$40021860 constant EXTI_EXTI_EXTICR1  \ offset: 0x60 : EXTI external interrupt selection register
$40021864 constant EXTI_EXTI_EXTICR2  \ offset: 0x64 : EXTI external interrupt selection register
$40021868 constant EXTI_EXTI_EXTICR3  \ offset: 0x68 : EXTI external interrupt selection register
$4002186c constant EXTI_EXTI_EXTICR4  \ offset: 0x6C : EXTI external interrupt selection register
$40021880 constant EXTI_EXTI_IMR1  \ offset: 0x80 : EXTI CPU wakeup with interrupt mask register 1
$40021884 constant EXTI_EXTI_EMR1  \ offset: 0x84 : EXTI CPU wakeup with event mask register
$40021890 constant EXTI_EXTI_IMR2  \ offset: 0x90 : EXTI CPU wakeup with interrupt mask register 2
$40021894 constant EXTI_EXTI_EMR2  \ offset: 0x94 : EXTI CPU wakeup with event mask register 2

