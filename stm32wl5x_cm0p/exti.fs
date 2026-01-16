\
\ @file exti.fs
\ @brief External interrupt/event       controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief EXTI rising trigger selection register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_RTSR1_RT0                              \ rising trigger event configuration bit of configurable event input 0
$00000002 constant EXTI_EXTI_RTSR1_RT1                              \ rising trigger event configuration bit of configurable event input 1
$00000004 constant EXTI_EXTI_RTSR1_RT2                              \ rising trigger event configuration bit of configurable event input 2
$00000008 constant EXTI_EXTI_RTSR1_RT3                              \ rising trigger event configuration bit of configurable event input 3
$00000010 constant EXTI_EXTI_RTSR1_RT4                              \ rising trigger event configuration bit of configurable event input 4
$00000020 constant EXTI_EXTI_RTSR1_RT5                              \ rising trigger event configuration bit of configurable event input 5
$00000040 constant EXTI_EXTI_RTSR1_RT6                              \ rising trigger event configuration bit of configurable event input 6
$00000080 constant EXTI_EXTI_RTSR1_RT7                              \ rising trigger event configuration bit of configurable event input 7
$00000100 constant EXTI_EXTI_RTSR1_RT8                              \ rising trigger event configuration bit of configurable event input 8
$00000200 constant EXTI_EXTI_RTSR1_RT9                              \ rising trigger event configuration bit of configurable event input 9
$00000400 constant EXTI_EXTI_RTSR1_RT10                             \ rising trigger event configuration bit of configurable event input 10
$00000800 constant EXTI_EXTI_RTSR1_RT11                             \ rising trigger event configuration bit of configurable event input 11
$00001000 constant EXTI_EXTI_RTSR1_RT12                             \ rising trigger event configuration bit of configurable event input 12
$00002000 constant EXTI_EXTI_RTSR1_RT13                             \ rising trigger event configuration bit of configurable event input 13
$00004000 constant EXTI_EXTI_RTSR1_RT14                             \ rising trigger event configuration bit of configurable event input 14
$00008000 constant EXTI_EXTI_RTSR1_RT15                             \ rising trigger event configuration bit of configurable event input 15
$00010000 constant EXTI_EXTI_RTSR1_RT16                             \ rising trigger event configuration bit of configurable event input 16
$00200000 constant EXTI_EXTI_RTSR1_RT21                             \ rising trigger event configuration bit of configurable event input 21
$00400000 constant EXTI_EXTI_RTSR1_RT22                             \ rising trigger event configuration bit of configurable event input 22 Note: The configurable event inputs are edge triggered. No glitch must be generated on these inputs. If a rising edge on the configurable event input occurs while writing to the register, the associated pending bit is not set. Note: Rising and falling edge triggers can be set for the same configurable event input. In this case, both edges generate a trigger.


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_FTSR1_FT0                              \ falling trigger event configuration bit of configurable event input 0
$00000002 constant EXTI_EXTI_FTSR1_FT1                              \ falling trigger event configuration bit of configurable event input 1
$00000004 constant EXTI_EXTI_FTSR1_FT2                              \ falling trigger event configuration bit of configurable event input 2
$00000008 constant EXTI_EXTI_FTSR1_FT3                              \ falling trigger event configuration bit of configurable event input 3
$00000010 constant EXTI_EXTI_FTSR1_FT4                              \ falling trigger event configuration bit of configurable event input 4
$00000020 constant EXTI_EXTI_FTSR1_FT5                              \ falling trigger event configuration bit of configurable event input 5
$00000040 constant EXTI_EXTI_FTSR1_FT6                              \ falling trigger event configuration bit of configurable event input 6
$00000080 constant EXTI_EXTI_FTSR1_FT7                              \ falling trigger event configuration bit of configurable event input 7
$00000100 constant EXTI_EXTI_FTSR1_FT8                              \ falling trigger event configuration bit of configurable event input 8
$00000200 constant EXTI_EXTI_FTSR1_FT9                              \ falling trigger event configuration bit of configurable event input 9
$00000400 constant EXTI_EXTI_FTSR1_FT10                             \ falling trigger event configuration bit of configurable event input 10
$00000800 constant EXTI_EXTI_FTSR1_FT11                             \ falling trigger event configuration bit of configurable event input 11
$00001000 constant EXTI_EXTI_FTSR1_FT12                             \ falling trigger event configuration bit of configurable event input 12
$00002000 constant EXTI_EXTI_FTSR1_FT13                             \ falling trigger event configuration bit of configurable event input 13
$00004000 constant EXTI_EXTI_FTSR1_FT14                             \ falling trigger event configuration bit of configurable event input 14
$00008000 constant EXTI_EXTI_FTSR1_FT15                             \ falling trigger event configuration bit of configurable event input 15
$00010000 constant EXTI_EXTI_FTSR1_FT16                             \ falling trigger event configuration bit of configurable event input 16
$00200000 constant EXTI_EXTI_FTSR1_FT21                             \ falling trigger event configuration bit of configurable event input 21
$00400000 constant EXTI_EXTI_FTSR1_FT22                             \ falling trigger event configuration bit of configurable event input 22 Note: The configurable event inputs are edge triggered. No glitch must be generated on these inputs. If a falling edge on the configurable event input occurs while writing to the register, the associated pending bit is not set. Note: Rising and falling edge triggers can be set for the same configurable event input. In this case, both edges generate a trigger.


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_SWIER1_SWI0                            \ Software interrupt on line 0
$00000002 constant EXTI_EXTI_SWIER1_SWI1                            \ Software interrupt on line 1
$00000004 constant EXTI_EXTI_SWIER1_SWI2                            \ Software interrupt on line 2
$00000008 constant EXTI_EXTI_SWIER1_SWI3                            \ Software interrupt on line 3
$00000010 constant EXTI_EXTI_SWIER1_SWI4                            \ Software interrupt on line 4
$00000020 constant EXTI_EXTI_SWIER1_SWI5                            \ Software interrupt on line 5
$00000040 constant EXTI_EXTI_SWIER1_SWI6                            \ Software interrupt on line 6
$00000080 constant EXTI_EXTI_SWIER1_SWI7                            \ Software interrupt on line 7
$00000100 constant EXTI_EXTI_SWIER1_SWI8                            \ Software interrupt on line 8
$00000200 constant EXTI_EXTI_SWIER1_SWI9                            \ Software interrupt on line 9
$00000400 constant EXTI_EXTI_SWIER1_SWI10                           \ Software interrupt on line 10
$00000800 constant EXTI_EXTI_SWIER1_SWI11                           \ Software interrupt on line 11
$00001000 constant EXTI_EXTI_SWIER1_SWI12                           \ Software interrupt on line 12
$00002000 constant EXTI_EXTI_SWIER1_SWI13                           \ Software interrupt on line 13
$00004000 constant EXTI_EXTI_SWIER1_SWI14                           \ Software interrupt on line 14
$00008000 constant EXTI_EXTI_SWIER1_SWI15                           \ Software interrupt on line 15
$00010000 constant EXTI_EXTI_SWIER1_SWI16                           \ Software interrupt on line 16
$00200000 constant EXTI_EXTI_SWIER1_SWI21                           \ Software interrupt on line 21
$00400000 constant EXTI_EXTI_SWIER1_SWI22                           \ Software interrupt on line 22 A software interrupt is generated independently from the setting in EXTI_RTSR and EXTI_FTSR. This bit always returns 0 when read. This bit is automatically cleared by hardware.


\
\ @brief EXTI pending register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_PR1_PIF0                               \ pending bit on event input 0
$00000002 constant EXTI_EXTI_PR1_PIF1                               \ pending bit on event input 1
$00000004 constant EXTI_EXTI_PR1_PIF2                               \ pending bit on event input 2
$00000008 constant EXTI_EXTI_PR1_PIF3                               \ pending bit on event input 3
$00000010 constant EXTI_EXTI_PR1_PIF4                               \ pending bit on event input 4
$00000020 constant EXTI_EXTI_PR1_PIF5                               \ pending bit on event input 5
$00000040 constant EXTI_EXTI_PR1_PIF6                               \ pending bit on event input 6
$00000080 constant EXTI_EXTI_PR1_PIF7                               \ pending bit on event input 7
$00000100 constant EXTI_EXTI_PR1_PIF8                               \ pending bit on event input 8
$00000200 constant EXTI_EXTI_PR1_PIF9                               \ pending bit on event input 9
$00000400 constant EXTI_EXTI_PR1_PIF10                              \ pending bit on event input 10
$00000800 constant EXTI_EXTI_PR1_PIF11                              \ pending bit on event input 11
$00001000 constant EXTI_EXTI_PR1_PIF12                              \ pending bit on event input 12
$00002000 constant EXTI_EXTI_PR1_PIF13                              \ pending bit on event input 13
$00004000 constant EXTI_EXTI_PR1_PIF14                              \ pending bit on event input 14
$00008000 constant EXTI_EXTI_PR1_PIF15                              \ pending bit on event input 15
$00010000 constant EXTI_EXTI_PR1_PIF16                              \ pending bit on event input 16
$00200000 constant EXTI_EXTI_PR1_PIF21                              \ pending bit on event input 21
$00400000 constant EXTI_EXTI_PR1_PIF22                              \ pending bit on event input 22 These bits are set when the selected edge event or an EXTI_SWIER software trigger arrives on the configurable event line. This bit is cleared by writing 1 to it.


\
\ @brief EXTI rising trigger selection register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_RTSR2_RT34                             \ rising trigger event configuration bit of configurable event input 34
$00000100 constant EXTI_EXTI_RTSR2_RT40                             \ rising trigger event configuration bit of configurable event input 40
$00000200 constant EXTI_EXTI_RTSR2_RT41                             \ rising trigger event configuration bit of configurable event input 41
$00002000 constant EXTI_EXTI_RTSR2_RT45                             \ rising trigger event configuration bit of configurable event input 45 Note: The configurable event inputs are edge triggered. No glitch must be generated on these inputs. If a rising edge on the configurable event input occurs while writing to the register, the associated pending bit is not set. Note: Rising and falling edge triggers can be set for the same configurable event input. In this case, both edges generate a trigger.


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_FTSR2_FT34                             \ falling trigger event configuration bit of configurable event input 34
$00000100 constant EXTI_EXTI_FTSR2_FT40                             \ falling trigger event configuration bit of configurable event input 40
$00000200 constant EXTI_EXTI_FTSR2_FT41                             \ falling trigger event configuration bit of configurable event input 41
$00002000 constant EXTI_EXTI_FTSR2_FT45                             \ falling trigger event configuration bit of configurable event input 45 Note: The configurable event inputs are edge triggered. No glitch must be generated on these inputs. If a falling edge on the configurable event input occurs while writing to the register, the associated pending bit is not set. Note: Rising and falling edge triggers can be set for the same configurable event input. In this case, both edges generate a trigger.


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_SWIER2_SWI34                           \ software interrupt on event 34
$00000100 constant EXTI_EXTI_SWIER2_SWI40                           \ software interrupt on event 40
$00000200 constant EXTI_EXTI_SWIER2_SWI41                           \ software interrupt on event 41
$00002000 constant EXTI_EXTI_SWIER2_SWI45                           \ software interrupt on event 45 A software interrupt is generated independently from the setting in EXTI_RTSR and EXTI_FTSR. This bit always returns 0 when read. This bit is automatically cleared by hardware.


\
\ @brief EXTI pending register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_PR2_PIF34                              \ pending bit on event input 34
$00000100 constant EXTI_EXTI_PR2_PIF40                              \ pending bit on event input 40
$00000200 constant EXTI_EXTI_PR2_PIF41                              \ pending bit on event input 41
$00002000 constant EXTI_EXTI_PR2_PIF45                              \ pending bit on event input 45 These bits are set when the selected edge event or an EXTI_SWIER software trigger arrives on the configurable event line. This bit is cleared by writing 1 to it.


\
\ @brief EXTI interrupt mask register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant EXTI_EXTI_C1IMR1_IM                              \ Wake-up with interrupt mask on event input x For each bit of this field:


\
\ @brief EXTI event mask register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_C1EMR1_EM0                             \ Wake-up with event generation mask on event input 0
$00000002 constant EXTI_EXTI_C1EMR1_EM1                             \ Wake-up with event generation mask on event input 1
$00000004 constant EXTI_EXTI_C1EMR1_EM2                             \ Wake-up with event generation mask on event input 2
$00000008 constant EXTI_EXTI_C1EMR1_EM3                             \ Wake-up with event generation mask on event input 3
$00000010 constant EXTI_EXTI_C1EMR1_EM4                             \ Wake-up with event generation mask on event input 4
$00000020 constant EXTI_EXTI_C1EMR1_EM5                             \ Wake-up with event generation mask on event input 5
$00000040 constant EXTI_EXTI_C1EMR1_EM6                             \ Wake-up with event generation mask on event input 6
$00000080 constant EXTI_EXTI_C1EMR1_EM7                             \ Wake-up with event generation mask on event input 7
$00000100 constant EXTI_EXTI_C1EMR1_EM8                             \ Wake-up with event generation mask on event input 8
$00000200 constant EXTI_EXTI_C1EMR1_EM9                             \ Wake-up with event generation mask on event input 19
$00000400 constant EXTI_EXTI_C1EMR1_EM10                            \ Wake-up with event generation mask on event input 10
$00000800 constant EXTI_EXTI_C1EMR1_EM11                            \ Wake-up with event generation mask on event input 11
$00001000 constant EXTI_EXTI_C1EMR1_EM12                            \ Wake-up with event generation mask on event input 12
$00002000 constant EXTI_EXTI_C1EMR1_EM13                            \ Wake-up with event generation mask on event input 13
$00004000 constant EXTI_EXTI_C1EMR1_EM14                            \ Wake-up with event generation mask on event input 14
$00008000 constant EXTI_EXTI_C1EMR1_EM15                            \ Wake-up with event generation mask on event input 15
$00020000 constant EXTI_EXTI_C1EMR1_EM17                            \ Wake-up with event generation mask on event input 17
$00040000 constant EXTI_EXTI_C1EMR1_EM18                            \ Wake-up with event generation mask on event input 18
$00080000 constant EXTI_EXTI_C1EMR1_EM19                            \ Wake-up with event generation mask on event input 19
$00100000 constant EXTI_EXTI_C1EMR1_EM20                            \ Wake-up with event generation mask on event input 20
$00200000 constant EXTI_EXTI_C1EMR1_EM21                            \ Wake-up with event generation mask on event input 21
$00400000 constant EXTI_EXTI_C1EMR1_EM22                            \ Wake-up with event generation mask on event input 22


\
\ @brief EXTI interrupt mask register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_C1IMR2_IM34                            \ Wake-up with interrupt mask on event input 34
$00000010 constant EXTI_EXTI_C1IMR2_IM36                            \ Wake-up with interrupt mask on event input 36
$00000020 constant EXTI_EXTI_C1IMR2_IM37                            \ Wake-up with interrupt mask on event input 37
$00000040 constant EXTI_EXTI_C1IMR2_IM38                            \ Wake-up with interrupt mask on event input 38
$00000080 constant EXTI_EXTI_C1IMR2_IM39                            \ Wake-up with interrupt mask on event input 39
$00000100 constant EXTI_EXTI_C1IMR2_IM40                            \ Wake-up with interrupt mask on event input 40
$00000200 constant EXTI_EXTI_C1IMR2_IM41                            \ Wake-up with interrupt mask on event input 41
$00000400 constant EXTI_EXTI_C1IMR2_IM42                            \ Wake-up with interrupt mask on event input 42
$00000800 constant EXTI_EXTI_C1IMR2_IM43                            \ Wake-up with interrupt mask on event input 43
$00001000 constant EXTI_EXTI_C1IMR2_IM44                            \ Wake-up with interrupt mask on event input 44
$00002000 constant EXTI_EXTI_C1IMR2_IM45                            \ Wake-up with interrupt mask on event input 45
$00004000 constant EXTI_EXTI_C1IMR2_IM46                            \ Wake-up with interrupt mask on event input 46


\
\ @brief EXTI event mask register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000100 constant EXTI_EXTI_C1EMR2_EM40                            \ Wake-up with event generation mask on event input 40
$00000200 constant EXTI_EXTI_C1EMR2_EM41                            \ Wake-up with event generation mask on event input 41


\
\ @brief EXTI interrupt mask register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant EXTI_EXTI_C2IMR1_IM                              \ Wake-up with interrupt mask on event input x For each bit of this field:


\
\ @brief EXTI event mask register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_C2EMR1_EM0                             \ Wake-up with event generation mask on event input 0
$00000002 constant EXTI_EXTI_C2EMR1_EM1                             \ Wake-up with event generation mask on event input 1
$00000004 constant EXTI_EXTI_C2EMR1_EM2                             \ Wake-up with event generation mask on event input 2
$00000008 constant EXTI_EXTI_C2EMR1_EM3                             \ Wake-up with event generation mask on event input 3
$00000010 constant EXTI_EXTI_C2EMR1_EM4                             \ Wake-up with event generation mask on event input 4
$00000020 constant EXTI_EXTI_C2EMR1_EM5                             \ Wake-up with event generation mask on event input 5
$00000040 constant EXTI_EXTI_C2EMR1_EM6                             \ Wake-up with event generation mask on event input 6
$00000080 constant EXTI_EXTI_C2EMR1_EM7                             \ Wake-up with event generation mask on event input 7
$00000100 constant EXTI_EXTI_C2EMR1_EM8                             \ Wake-up with event generation mask on event input 8
$00000200 constant EXTI_EXTI_C2EMR1_EM9                             \ Wake-up with event generation mask on event input 19
$00000400 constant EXTI_EXTI_C2EMR1_EM10                            \ Wake-up with event generation mask on event input 10
$00000800 constant EXTI_EXTI_C2EMR1_EM11                            \ Wake-up with event generation mask on event input 11
$00001000 constant EXTI_EXTI_C2EMR1_EM12                            \ Wake-up with event generation mask on event input 12
$00002000 constant EXTI_EXTI_C2EMR1_EM13                            \ Wake-up with event generation mask on event input 13
$00004000 constant EXTI_EXTI_C2EMR1_EM14                            \ Wake-up with event generation mask on event input 14
$00008000 constant EXTI_EXTI_C2EMR1_EM15                            \ Wake-up with event generation mask on event input 15
$00020000 constant EXTI_EXTI_C2EMR1_EM17                            \ Wake-up with event generation mask on event input 17
$00040000 constant EXTI_EXTI_C2EMR1_EM18                            \ Wake-up with event generation mask on event input 18
$00080000 constant EXTI_EXTI_C2EMR1_EM19                            \ Wake-up with event generation mask on event input 19
$00100000 constant EXTI_EXTI_C2EMR1_EM20                            \ Wake-up with event generation mask on event input 20
$00200000 constant EXTI_EXTI_C2EMR1_EM21                            \ Wake-up with event generation mask on event input 21
$00400000 constant EXTI_EXTI_C2EMR1_EM22                            \ Wake-up with event generation mask on event input 22


\
\ @brief EXTI interrupt mask register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_C2IMR2_IM34                            \ Wake-up with interrupt mask on event input 34
$00000010 constant EXTI_EXTI_C2IMR2_IM36                            \ Wake-up with interrupt mask on event input 36
$00000020 constant EXTI_EXTI_C2IMR2_IM37                            \ Wake-up with interrupt mask on event input 37
$00000040 constant EXTI_EXTI_C2IMR2_IM38                            \ Wake-up with interrupt mask on event input 38
$00000080 constant EXTI_EXTI_C2IMR2_IM39                            \ Wake-up with interrupt mask on event input 39
$00000100 constant EXTI_EXTI_C2IMR2_IM40                            \ Wake-up with interrupt mask on event input 40
$00000200 constant EXTI_EXTI_C2IMR2_IM41                            \ Wake-up with interrupt mask on event input 41
$00000400 constant EXTI_EXTI_C2IMR2_IM42                            \ Wake-up with interrupt mask on event input 42
$00000800 constant EXTI_EXTI_C2IMR2_IM43                            \ Wake-up with interrupt mask on event input 43
$00001000 constant EXTI_EXTI_C2IMR2_IM44                            \ Wake-up with interrupt mask on event input 44
$00002000 constant EXTI_EXTI_C2IMR2_IM45                            \ Wake-up with interrupt mask on event input 45
$00004000 constant EXTI_EXTI_C2IMR2_IM46                            \ Wake-up with interrupt mask on event input 46


\
\ @brief EXTI event mask register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000100 constant EXTI_EXTI_C2EMR2_EM40                            \ Wake-up with event generation mask on event input 40
$00000200 constant EXTI_EXTI_C2EMR2_EM41                            \ Wake-up with event generation mask on event input 41


\
\ @brief External interrupt/event controller
\
$58000800 constant EXTI_EXTI_RTSR1  \ offset: 0x00 : EXTI rising trigger selection register
$58000804 constant EXTI_EXTI_FTSR1  \ offset: 0x04 : EXTI falling trigger selection register
$58000808 constant EXTI_EXTI_SWIER1  \ offset: 0x08 : EXTI software interrupt event register
$5800080c constant EXTI_EXTI_PR1  \ offset: 0x0C : EXTI pending register
$58000820 constant EXTI_EXTI_RTSR2  \ offset: 0x20 : EXTI rising trigger selection register
$58000824 constant EXTI_EXTI_FTSR2  \ offset: 0x24 : EXTI falling trigger selection register
$58000828 constant EXTI_EXTI_SWIER2  \ offset: 0x28 : EXTI software interrupt event register
$5800082c constant EXTI_EXTI_PR2  \ offset: 0x2C : EXTI pending register
$58000880 constant EXTI_EXTI_C1IMR1  \ offset: 0x80 : EXTI interrupt mask register
$58000884 constant EXTI_EXTI_C1EMR1  \ offset: 0x84 : EXTI event mask register
$58000890 constant EXTI_EXTI_C1IMR2  \ offset: 0x90 : EXTI interrupt mask register
$58000894 constant EXTI_EXTI_C1EMR2  \ offset: 0x94 : EXTI event mask register
$580008c0 constant EXTI_EXTI_C2IMR1  \ offset: 0xC0 : EXTI interrupt mask register
$580008c4 constant EXTI_EXTI_C2EMR1  \ offset: 0xC4 : EXTI event mask register
$580008d0 constant EXTI_EXTI_C2IMR2  \ offset: 0xD0 : EXTI interrupt mask register
$580008d4 constant EXTI_EXTI_C2EMR2  \ offset: 0xD4 : EXTI event mask register

