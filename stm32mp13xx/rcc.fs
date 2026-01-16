\
\ @file rcc.fs
\ @brief RCC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RCC secure configuration register
\ Address offset: 0x00
\ Reset value: 0x83FF3F1F
\

$00000001 constant RCC_RCC_SECCFGR_HSISEC                           \ Secure state of the HSI clock
$00000002 constant RCC_RCC_SECCFGR_CSISEC                           \ Secure state of the CSI clock
$00000004 constant RCC_RCC_SECCFGR_HSESEC                           \ Secure state of the HSE clock
$00000008 constant RCC_RCC_SECCFGR_LSISEC                           \ Secure state of the LSI clock
$00000010 constant RCC_RCC_SECCFGR_LSESEC                           \ Secure state of the LSE clock
$00000100 constant RCC_RCC_SECCFGR_PLL12SEC                         \ Secure state of the PLL1 and PLL2 clocks
$00000200 constant RCC_RCC_SECCFGR_PLL3SEC                          \ Secure state of the PLL3 clock
$00000400 constant RCC_RCC_SECCFGR_PLL4SEC                          \ Secure state of the PLL4 clock
$00000800 constant RCC_RCC_SECCFGR_MPUSEC                           \ Secure state of the MPU sub-system clock
$00001000 constant RCC_RCC_SECCFGR_AXISEC                           \ Secure state of the AXI sub-system clock
$00002000 constant RCC_RCC_SECCFGR_MLAHBSEC                         \ Secure state of the MLAHB sub-system clock
$00010000 constant RCC_RCC_SECCFGR_APB3DIVSEC                       \ Secure state of the APB3DIV divider
$00020000 constant RCC_RCC_SECCFGR_APB4DIVSEC                       \ Secure state of the APB4DIV divider
$00040000 constant RCC_RCC_SECCFGR_APB5DIVSEC                       \ Secure state of the APB5DIV divider
$00080000 constant RCC_RCC_SECCFGR_APB6DIVSEC                       \ Secure state of the APB6DIV divider
$00100000 constant RCC_RCC_SECCFGR_TIMG3SEC                         \ Secure state of the TIMG3 prescaler
$00200000 constant RCC_RCC_SECCFGR_CPERSEC                          \ Secure state of the common peripheral clock
$00400000 constant RCC_RCC_SECCFGR_MCO1SEC                          \ Secure state of the MCO1 clock
$00800000 constant RCC_RCC_SECCFGR_MCO2SEC                          \ Secure state of the MCO2 clock
$01000000 constant RCC_RCC_SECCFGR_STPSEC                           \ Secure state of the Stop modes
$02000000 constant RCC_RCC_SECCFGR_RSTSEC                           \ Secure state of the reset
$80000000 constant RCC_RCC_SECCFGR_PWRSEC                           \ Secure state of the PWR block This control bit generates the output signal rcc_pwr_sec which is connected to the PWR block.


\
\ @brief RCC stop request set register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_SREQSETR_STPREQ_P0                    \ Stop request from MPU processor Set by software Indicates if the MPU processor allow or not the entry in CStop/CStandby modes for MPU domain, when the MPU is in WFI. Note: the entry selection between CStop and CStandby is controlled by PWR_MPUCR.PDDS and PWR_CR1.STOP2 control bits.


\
\ @brief RCC stop request clear register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_SREQCLRR_STPREQ_P0                    \ Stop request from MPU processor Cleared by software Indicates if the MPU processor allow or not the entry in CStop/CStandby modes for MPU domain, when the MPU is in WFI. Note: the entry selection between CStop and CStandby is controlled by PWR_MPUCR.PDDS and PWR_CR1.STOP2 control bits.


\
\ @brief RCC application reset control register
\ Address offset: 0x108
\ Reset value: 0x00007F00
\

$00000001 constant RCC_RCC_MP_APRSTCR_RDCTLEN                       \ Reset delay control enable Set and reset by software.
$00007f00 constant RCC_RCC_MP_APRSTCR_RSTTO                         \ Reset timeout delay adjust


\
\ @brief RCC application reset status register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00007f00 constant RCC_RCC_MP_APRSTSR_RSTTOV                        \ Reset timeout delay value Set by hardware in order to give the value of the timeout counter. This function is only available when the RDCTLEN = '1'. If RSTTOS = '0' it means that a timeout occurred.


\
\ @brief RCC low-power Stop modes delay control register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$003fffff constant RCC_RCC_PWRLPDLYCR_PWRLP_DLY                     \ PWRLP_TEMPO value Written by software. This register contains the delay value to be observed before activating the PLLs and interconnect clocks, after one of the system Stop modes. The delay is counted with the HSI clock. The user has to take into account HSIDIV value. The delay value is given by the following formula: PWRLP_DLY[21:0] / FHSI ...


\
\ @brief RCC global reset control set register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_GRSTCSETR_MPSYSRST                    \ System reset Set by software, cleared by hardware.
$00000010 constant RCC_RCC_MP_GRSTCSETR_MPUP0RST                    \ MPU processor reset Set by software, cleared by hardware when the reset command is completed. Note that the Snoop Control Unit of the MPU (SCU) is not reset.


\
\ @brief RCC BOOTROM reset status clear register
\ Address offset: 0x118
\ Reset value: 0x00000015
\

$00000001 constant RCC_RCC_BR_RSTSCLRR_PORRSTF                      \ POR/PDR reset flag Cleared by software, set by hardware when a POR/PDR reset occurred.
$00000002 constant RCC_RCC_BR_RSTSCLRR_BORRSTF                      \ BOR reset flag Cleared by software, set by hardware when a BOR reset occurred.
$00000004 constant RCC_RCC_BR_RSTSCLRR_PADRSTF                      \ NRST reset flag Cleared by software, set by hardware when a PAD reset occurred.
$00000008 constant RCC_RCC_BR_RSTSCLRR_HCSSRSTF                     \ HSE CSS reset flag Cleared by software, set by hardware when a failure is detected on HSE.
$00000010 constant RCC_RCC_BR_RSTSCLRR_VCORERSTF                    \ VDDCORE reset flag Cleared by software, set by hardware when a reset occurred because VDDCORE is lower than the expected value.
$00000020 constant RCC_RCC_BR_RSTSCLRR_VCPURSTF                     \ VDDCPU reset flag Cleared by software, set by hardware when a reset occurred because VDDCPU is lower than the expected value.
$00000040 constant RCC_RCC_BR_RSTSCLRR_MPSYSRSTF                    \ MPU System reset flag Cleared by software, set by hardware when a MPU system reset occurred.
$00000100 constant RCC_RCC_BR_RSTSCLRR_IWDG1RSTF                    \ IWDG1 reset flag Cleared by software, set by hardware when a IWDG1 reset occurred.
$00000200 constant RCC_RCC_BR_RSTSCLRR_IWDG2RSTF                    \ IWDG2 reset flag Cleared by software, set by hardware when a IWDG2 reset occurred.
$00002000 constant RCC_RCC_BR_RSTSCLRR_MPUP0RSTF                    \ MPU processor reset flag Cleared by software, set by hardware when a MPU processor reset occurred.


\
\ @brief RCC reset status set register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_RSTSSETR_PORRSTF                      \ POR/PDR reset flag Set by the BOOTROM code when a POR/PDR reset occurred.
$00000002 constant RCC_RCC_MP_RSTSSETR_BORRSTF                      \ BOR reset flag Set by the BOOTROM code when a BOR reset occurred.
$00000004 constant RCC_RCC_MP_RSTSSETR_PADRSTF                      \ NRST reset flag Set by the BOOTROM code when a PAD reset occurred.
$00000008 constant RCC_RCC_MP_RSTSSETR_HCSSRSTF                     \ HSE CSS reset flag Set by the BOOTROM code when a failure is detected on HSE.
$00000010 constant RCC_RCC_MP_RSTSSETR_VCORERSTF                    \ VDDCORE reset flag Set by the BOOTROM code when a reset occurred because VDDCORE is lower than the expected value.
$00000020 constant RCC_RCC_MP_RSTSSETR_VCPURSTF                     \ VCPU reset flag Set by the BOOTROM code when a reset occurred because VCPU is lower than the expected value.
$00000040 constant RCC_RCC_MP_RSTSSETR_MPSYSRSTF                    \ MPU System reset flag Set by the BOOTROM code when a MPU system reset occurred.
$00000100 constant RCC_RCC_MP_RSTSSETR_IWDG1RSTF                    \ IWDG1 reset flag Set by the BOOTROM code when a IWDG1 reset occurred.
$00000200 constant RCC_RCC_MP_RSTSSETR_IWDG2RSTF                    \ IWDG2 reset flag Set by the BOOTROM code when a IWDG2 reset occurred.
$00000400 constant RCC_RCC_MP_RSTSSETR_STP2RSTF                     \ Stop2 reset flag Set by the BOOTROM code when exiting from Stop2.
$00000800 constant RCC_RCC_MP_RSTSSETR_STDBYRSTF                    \ System Standby reset flag Set by the BOOTROM code when exiting from Standby.
$00001000 constant RCC_RCC_MP_RSTSSETR_CSTDBYRSTF                   \ MPU CStandby reset flag Set by the BOOTROM code when the MPU exits from CStandby.
$00002000 constant RCC_RCC_MP_RSTSSETR_MPUP0RSTF                    \ MPU processor reset flag Set by the BOOTROM code when a MPU processor reset occurred.
$00008000 constant RCC_RCC_MP_RSTSSETR_SPARE                        \ Spare bit Set and reset by software. Reserved for future use.


\
\ @brief RCC reset status clear register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_RSTSCLRR_PORRSTF                      \ POR/PDR reset flag Cleared by software, set by the BOOTROM code when a POR/PDR reset occurred.
$00000002 constant RCC_RCC_MP_RSTSCLRR_BORRSTF                      \ BOR reset flag Cleared by software, set by the BOOTROM code when a BOR reset occurred.
$00000004 constant RCC_RCC_MP_RSTSCLRR_PADRSTF                      \ NRST reset flag Cleared by software, set by the BOOTROM code when a PAD reset occurred.
$00000008 constant RCC_RCC_MP_RSTSCLRR_HCSSRSTF                     \ HSE CSS reset flag Cleared by software, set by the BOOTROM code when a failure is detected on HSE.
$00000010 constant RCC_RCC_MP_RSTSCLRR_VCORERSTF                    \ VDDCORE reset flag Cleared by software, set by the BOOTROM code when a reset occurred because VDDCORE is lower than the expected value.
$00000020 constant RCC_RCC_MP_RSTSCLRR_VCPURSTF                     \ VDDCPU reset flag Cleared by software, set by the BOOTROM code when a reset occurred because VDDCPU is lower than the expected value.
$00000040 constant RCC_RCC_MP_RSTSCLRR_MPSYSRSTF                    \ MPU System reset flag Cleared by software, set by the BOOTROM code when a MPU system reset occurred.
$00000100 constant RCC_RCC_MP_RSTSCLRR_IWDG1RSTF                    \ IWDG1 reset flag Cleared by software, set by the BOOTROM code when a IWDG1 reset occurred.
$00000200 constant RCC_RCC_MP_RSTSCLRR_IWDG2RSTF                    \ IWDG2 reset flag Cleared by software, set by the BOOTROM code when a IWDG2 reset occurred.
$00000400 constant RCC_RCC_MP_RSTSCLRR_STP2RSTF                     \ Stop2 reset flag Cleared by software, set by the BOOTROM code when exiting from Stop2.
$00000800 constant RCC_RCC_MP_RSTSCLRR_STDBYRSTF                    \ System Standby reset flag Cleared by software, set by the BOOTROM code when exiting from Standby.
$00001000 constant RCC_RCC_MP_RSTSCLRR_CSTDBYRSTF                   \ MPU CStandby reset flag Cleared by software, set by the BOOTROM code when the MPU exits from CStandby.
$00002000 constant RCC_RCC_MP_RSTSCLRR_MPUP0RSTF                    \ MPU processor reset flag Cleared by software, set by the BOOTROM code when a MPU processor reset occurred.
$00008000 constant RCC_RCC_MP_RSTSCLRR_SPARE                        \ Spare bit Set and reset by software. Reserved for future use.


\
\ @brief RCC IWDG clock freeze set register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_IWDGFZSETR_FZ_IWDG1                   \ Freeze the IWDG1 clock If IWDG1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set once by the BOOTROM software after a system reset or Standby reset, or a CStandby reset, in order to freeze the IWDG1.
$00000002 constant RCC_RCC_MP_IWDGFZSETR_FZ_IWDG2                   \ Freeze the IWDG2 clock Set once by the BOOTROM software after a system reset or Standby reset, or a CStandby reset, in order to freeze the IWDG2.


\
\ @brief RCC IWDG clock freeze clear register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_IWDGFZCLRR_FZ_IWDG1                   \ Unfreeze the IWDG1 clock If IWDG1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by the BOOTROM software, in order to unfreeze the IWDG1.
$00000002 constant RCC_RCC_MP_IWDGFZCLRR_FZ_IWDG2                   \ Unfreeze the IWDG2 clock Cleared by the BOOTROM software, in order to unfreeze the IWDG2.


\
\ @brief RCC clock source interrupt enable register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_CIER_LSIRDYIE                         \ LSI ready Interrupt Enable If RCC_SECCFGR.LSISEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the LSI oscillator stabilization.
$00000002 constant RCC_RCC_MP_CIER_LSERDYIE                         \ LSE ready Interrupt Enable If RCC_SECCFGR.LSESEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the LSE oscillator stabilization.
$00000004 constant RCC_RCC_MP_CIER_HSIRDYIE                         \ HSI ready Interrupt Enable If RCC_SECCFGR.HSISEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the HSI oscillator stabilization.
$00000008 constant RCC_RCC_MP_CIER_HSERDYIE                         \ HSE ready Interrupt Enable If RCC_SECCFGR.HSESEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the HSE oscillator stabilization.
$00000010 constant RCC_RCC_MP_CIER_CSIRDYIE                         \ CSI ready Interrupt Enable If RCC_SECCFGR.CSISEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the CSI oscillator stabilization.
$00000100 constant RCC_RCC_MP_CIER_PLL1DYIE                         \ PLL1 ready Interrupt Enable If RCC_SECCFGR.PLL12SEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by PLL1 lock.
$00000200 constant RCC_RCC_MP_CIER_PLL2DYIE                         \ PLL2 ready Interrupt Enable If RCC_SECCFGR.PLL12SEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by PLL2 lock.
$00000400 constant RCC_RCC_MP_CIER_PLL3DYIE                         \ PLL3 ready Interrupt Enable If RCC_SECCFGR.PLL3SEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by PLL3 lock.
$00000800 constant RCC_RCC_MP_CIER_PLL4DYIE                         \ PLL4 ready Interrupt Enable If RCC_SECCFGR.PLL4SEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by PLL4 lock.
$00010000 constant RCC_RCC_MP_CIER_LSECSSIE                         \ LSE clock security system Interrupt Enable If RCC_SECCFGR.LSESEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the Clock Security System on external 32 kHz oscillator.
$00100000 constant RCC_RCC_MP_CIER_WKUPIE                           \ Wake up from CStop Interrupt Enable If RCC_SECCFGR.STPSEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable the generation of the interrupt used to wake up the MPU from CStop.


\
\ @brief RCC clock source interrupt flag register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_CIFR_LSIRDYF                          \ LSI ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the LSI clock becomes stable.
$00000002 constant RCC_RCC_MP_CIFR_LSERDYF                          \ LSE ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the LSE clock becomes stable.
$00000004 constant RCC_RCC_MP_CIFR_HSIRDYF                          \ HSI ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the HSI clock becomes stable.
$00000008 constant RCC_RCC_MP_CIFR_HSERDYF                          \ HSE ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the HSE clock becomes stable.
$00000010 constant RCC_RCC_MP_CIFR_CSIRDYF                          \ CSI ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the CSI clock becomes stable.
$00000100 constant RCC_RCC_MP_CIFR_PLL1DYF                          \ PLL1 ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the PLL1 locks.
$00000200 constant RCC_RCC_MP_CIFR_PLL2DYF                          \ PLL2 ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the PLL2 locks.
$00000400 constant RCC_RCC_MP_CIFR_PLL3DYF                          \ PLL3 ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the PLL3 locks.
$00000800 constant RCC_RCC_MP_CIFR_PLL4DYF                          \ PLL4 ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the PLL4 locks.
$00010000 constant RCC_RCC_MP_CIFR_LSECSSF                          \ LSE clock security system Interrupt Flag If RCC_SECCFGR.LSESEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when a failure is detected on the external 32 kHz oscillator.
$00100000 constant RCC_RCC_MP_CIFR_WKUPF                            \ Wake up from CStop Interrupt Flag If RCC_SECCFGR.STPSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the MPU needs to exit from CStop.


\
\ @brief RCC backup domain control register
\ Address offset: 0x400
\ Reset value: 0x00000020
\

$00000001 constant RCC_RCC_BDCR_LSEON                               \ LSE oscillator enabled Set and reset by software. If RCC_SECCFGR.LSESEC, a write access to this register field must be secure. A read access may be secure or non-secure.
$00000002 constant RCC_RCC_BDCR_LSEBYP                              \ LSE oscillator bypass Set and reset by software to bypass oscillator in debug mode. If RCC_SECCFGR.LSESEC, a write access to this register field must be secure. A read access may be secure or non-secure. This bit must not be written when the LSE is enabled (LSEON = '1'). Refer to Stop. for details.
$00000004 constant RCC_RCC_BDCR_LSERDY                              \ LSE oscillator ready Set and reset by hardware to indicate when the LSE is stable. This bit needs 6 cycles of lse_ck clock to fall down after LSEON has been set to '0'.
$00000008 constant RCC_RCC_BDCR_DIGBYP                              \ LSE digital bypass Set and reset by software to select the analog or digital bypass mode. If RCC_SECCFGR.LSESEC, a write access to this register field must be secure. A read access may be secure or non-secure.
$00000030 constant RCC_RCC_BDCR_LSEDRV                              \ LSE oscillator driving capability Written by software to select the driving capability of the LSE oscillator. If RCC_SECCFGR.LSESEC, a write access to this register field must be secure. A read access may be secure or non-secure.
$00000100 constant RCC_RCC_BDCR_LSECSSON                            \ LSE clock security system enable Set by software to enable the Clock Security System on 32 kHz oscillator. If RCC_SECCFGR.LSESEC, a write access to this register field must be secure. A read access may be secure or non-secure. Refer to for details on the activation and deactivation sequences. Once the LSECSSON bit is enabled it cannot be disabled, except after a LSE failure detection (LSECSSD = '1').
$00000200 constant RCC_RCC_BDCR_LSECSSD                             \ LSE clock security system failure detection Set by hardware to indicate when a failure has been detected by the Clock Security System on the external 32 kHz oscillator.
$00030000 constant RCC_RCC_BDCR_RTCSRC                              \ RTC clock source selection Set by software to select the clock source for the RTC. If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure. This field can be written only one time after backup domain reset. When a LSE failure occurs, the RTCSRC[1:0] is set to '00', and the software is allowed to write it again once. This field must be written before LSECSSON is enabled. Refer to for details.
$00100000 constant RCC_RCC_BDCR_RTCCKEN                             \ RTC clock enable Set and reset by software. If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure.
$80000000 constant RCC_RCC_BDCR_VSWRST                              \ VSW domain software reset Set and reset by software. If RCC_SECCFGR.RSTSEC, a write access to this field must be secure. A read access may be secure or non-secure.


\
\ @brief RCC reset duration and LSI control register
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_RDLSICR_LSION                            \ LSI oscillator enabled Set and reset by software. If RCC_SECCFGR.LSISEC, a write access to this field must be secure. A read access may be secure or non-secure. This bit is used to request the activation of the LSI oscillator. Note that IWDG1 and IWDG2 can also request the activation of LSI.
$00000002 constant RCC_RCC_RDLSICR_LSIRDY                           \ LSI oscillator ready Set and reset by hardware to indicate when the LSI is stable. This bit needs 3 cycles of lsi_ck clock to fall down after LSION has been set to '0'.
$001f0000 constant RCC_RCC_RDLSICR_MRD                              \ Minimum reset duration Written by software. If RCC_SECCFGR.RSTSEC, a write access to this field must be secure. A read access may be secure or non-secure. This field defines the minimum guaranteed duration of the NRST low pulse. The LSI oscillator is automatically enabled when needed by the RPCTL. ...
$07000000 constant RCC_RCC_RDLSICR_EADLY                            \ External access delays Written by software. If RCC_SECCFGR.RSTSEC, a write access to this field must be secure. A read access may be secure or non-secure. Time to wait before the BOOTROM performs any external access (UART, USB, QUADSPI, FMC, SDMMC,...)
$f8000000 constant RCC_RCC_RDLSICR_SPARE                            \ Spare bits Written by software. If RCC_SECCFGR.RSTSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reserved for future use.


\
\ @brief RCC oscillator clock enable set register
\ Address offset: 0x420
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_OCENSETR_HSION                           \ Set HSION bit Set by software to enable the HSI clock. This bit must be written by a secure agent if the HSI clock is configured as secure (i.e. if RCC_SECCFGR.HSISEC=1). The HSION is also set by hardware to force the HSI to ON when the product leaves Standby mode or one of the Stop modes.
$00000002 constant RCC_RCC_OCENSETR_HSIKERON                        \ Set HSIKERON bit Set by software to force the HSI to ON, even in (LP-)Stop mode, in order to be quickly available as kernel clock for peripherals. This bit must be written by a secure agent if the HSI clock is configured as secure (i.e. if RCC_SECCFGR.HSISEC=1). This bit has no effect on the value of HSION.
$00000010 constant RCC_RCC_OCENSETR_CSION                           \ Set CSION bit Set by software to enable CSI clock. This bit must be written by a secure agent if the CSI clock is configured as secure (i.e. if RCC_SECCFGR.CSISEC=1).
$00000020 constant RCC_RCC_OCENSETR_CSIKERON                        \ Set CSIKERON bit Set by software to force the CSI to ON, even in (LP-)Stop mode, in order to be quickly available as kernel clock for some peripherals. This bit must be written by a secure agent if the CSI clock is configured as secure (i.e. if RCC_SECCFGR.CSISEC=1). This bit has no effect on the value of CSION.
$00000080 constant RCC_RCC_OCENSETR_DIGBYP                          \ Set DIGBYP bit Set by software when the external HSE clock is connected to OSC_IN as a full-swing digital signal. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
$00000100 constant RCC_RCC_OCENSETR_HSEON                           \ Set HSEON bit Set by software to enable the HSE. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
$00000200 constant RCC_RCC_OCENSETR_HSEKERON                        \ Set HSEKERON bit Set by software to force the HSE to ON, even in (LP-)Stop mode, in order to be quickly available as kernel clock for some peripherals. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1). This bit has no effect on the value of HSEON.
$00000400 constant RCC_RCC_OCENSETR_HSEBYP                          \ Set HSEBYP bit Set by software in order to enable the bypass mode. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
$00000800 constant RCC_RCC_OCENSETR_HSECSSON                        \ Set the HSECSSON bit


\
\ @brief RCC oscillator clock enable clear register
\ Address offset: 0x424
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_OCENCLRR_HSION                           \ Clear of HSION bit Cleared by software to disable the HSI clock. This bit must be written by a secure agent if the HSI clock is configured as secure (i.e. if RCC_SECCFGR.HSISEC=1).
$00000002 constant RCC_RCC_OCENCLRR_HSIKERON                        \ Clear of HSIKERON bit Cleared by software in order to allow the HSI to be switched off in one of the Stop modes. This bit must be written by a secure agent if the HSI clock is configured as secure (i.e. if RCC_SECCFGR.HSISEC=1). This bit has no effect on the value of HSION.
$00000010 constant RCC_RCC_OCENCLRR_CSION                           \ Clear of CSION bit Cleared by software to disable the CSI clock. This bit must be written by a secure agent if the CSI clock is configured as secure (i.e. if RCC_SECCFGR.CSISEC=1).
$00000020 constant RCC_RCC_OCENCLRR_CSIKERON                        \ Clear of CSIKERON bit Cleared by software in order to allow the CSI to be switched off in one of the Stop modes. This bit must be written by a secure agent if the CSI clock is configured as secure (i.e. if RCC_SECCFGR.CSISEC=1). This bit has no effect on the value of CSION.
$00000080 constant RCC_RCC_OCENCLRR_DIGBYP                          \ Clear of DIGBYP bit Cleared by software when the external clock connected to OSC_IN is a low-swing signal. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
$00000100 constant RCC_RCC_OCENCLRR_HSEON                           \ Clear of HSEON bit Cleared by software to disable the HSE clock. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
$00000200 constant RCC_RCC_OCENCLRR_HSEKERON                        \ Clear HSEKERON bit Cleared by software in order to allow the HSE to be switched off in one of the Stop modes. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
$00000400 constant RCC_RCC_OCENCLRR_HSEBYP                          \ Clear the HSEBYP bit Cleared by software in order to disable the bypass mode. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).


\
\ @brief RCC oscillators and MPU and AXI clock ready register
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_OCRDYR_HSIRDY                            \ HSI clock ready flag Set by hardware to indicate that the HSI oscillator is stable.
$00000004 constant RCC_RCC_OCRDYR_HSIDIVRDY                         \ HSI divider ready flag Set and reset by hardware. As a write in HSIDIV has not an immediate effect on the frequency, this flag indicates the current status of the HSI divider. HSIDIVF will go immediately to '0' when HSIDIV value is changed, and will be set back to '1' when the output frequency matches the value programmed into HSIDIV
$00000010 constant RCC_RCC_OCRDYR_CSIRDY                            \ CSI clock ready flag Set by hardware to indicate that the CSI oscillator is stable.
$00000100 constant RCC_RCC_OCRDYR_HSERDY                            \ HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable.
$00800000 constant RCC_RCC_OCRDYR_MPUCKRDY                          \ MPU clock ready flag Set by hardware to indicate that the mpuss_ck clock is available.
$01000000 constant RCC_RCC_OCRDYR_AXICKRDY                          \ AXI sub-system clock ready flag Set by hardware to indicate that the axiss_ck clock is available.


\
\ @brief RCC HSI configuration register
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_HSICFGR_HSIDIV                           \ HSI clock divider Written by software. These bits allows the user to select a division ratio in order to select the wanted HSI clock frequency. The bit HSIDIVRDY of (RCC_OCRDYR) indicates when the new division ratio is taken into account.
$00007f00 constant RCC_RCC_HSICFGR_HSITRIM                          \ HSI clock trimming Set by software to adjust calibration. HSITRIM represents a signed value. HSITRIM field is added to the engineering Option Bytes loaded during reset phase (bsec_hsi_cal[11:0]) in order to form the calibration trimming value. HSICAL[11:0] = HSITRIM[6:0] + bsec_hsi_cal[11:0]. ... ...
$0fff0000 constant RCC_RCC_HSICFGR_HSICAL                           \ HSI clock calibration Set by hardware by option byte loading during system reset Adjusted by software through trimming bits HSITRIM. This field represents the sum of engineering Option Byte calibration value and HSITRIM bits value.


\
\ @brief RCC CSI configuration register
\ Address offset: 0x444
\ Reset value: 0x00001000
\

$00001f00 constant RCC_RCC_CSICFGR_CSITRIM                          \ CSI clock trimming Set by software to adjust calibration. CSITRIM field is added to the engineering Option Bytes loaded during reset phase (bsec_csi_cal[7:0]) in order to form the calibration trimming value. CSICAL[7:0] = CSITRIM[4:0] + bsec_csi_cal[7:0].
$00ff0000 constant RCC_RCC_CSICFGR_CSICAL                           \ CSI clock calibration Set by hardware by option byte loading during system reset. Adjusted by software through trimming bits CSITRIM. This field represents the sum of engineering Option Byte calibration value and CSITRIM bits value


\
\ @brief RCC MCO1 configuration register
\ Address offset: 0x460
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_MCO1CFGR_MCO1SEL                         \ MCO1 clock output selection Set and cleared by software. Clock source selection may generate glitches on MCO1. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
$000000f0 constant RCC_RCC_MCO1CFGR_MCO1DIV                         \ MCO1 prescaler Set and cleared by software to configure the prescaler of the MCO1. Modification of this prescaler may generate glitches on MCO1. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. Refer to for details. ...
$00001000 constant RCC_RCC_MCO1CFGR_MCO1ON                          \ Control of the MCO1 output Set and cleared by software to enable the MCO1 output


\
\ @brief RCC MCO2 configuration register
\ Address offset: 0x464
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_MCO2CFGR_MCO2SEL                         \ Micro-controller clock output 2 Set and cleared by software. Clock source selection may generate glitches on MCO2. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
$000000f0 constant RCC_RCC_MCO2CFGR_MCO2DIV                         \ MCO2 prescaler Set and cleared by software to configure the prescaler of the MCO2. Modification of this prescaler may generate glitches on MCO2. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. Refer to Section1.4.4: Clock Output generation (MCO1 & MCO2) for details. ...
$00001000 constant RCC_RCC_MCO2CFGR_MCO2ON                          \ Control of the MCO2 output Set and cleared by software to enable the MCO2 output


\
\ @brief RCC debug configuration register
\ Address offset: 0x468
\ Reset value: 0x00000001
\

$00000007 constant RCC_RCC_DBGCFGR_TRACEDIV                         \ Clock divider for the trace clock (ck_trace) Written by software to control the ck_trace clock division factor. It is possible to change this division ratio on-the-fly. others: aclk / 16
$00000100 constant RCC_RCC_DBGCFGR_DBGCKEN                          \ Clock enable for debug function Set and cleared by software to control the generation of the ck_apb_dbg clock (DEBUG APB clock), the ck_sys_dbg. See for additional information.
$00000200 constant RCC_RCC_DBGCFGR_TRACECKEN                        \ Clock enable for trace function Set and cleared by software to control the generation of the trace_ck clock. See for additional information.
$00001000 constant RCC_RCC_DBGCFGR_DBGRST                           \ Reset of the debug function Set and cleared by software to control the generation of the reset (dbg_rstn) for the trace and debug parts.


\
\ @brief RCC PLL1 and PLL2 reference clock selection register
\ Address offset: 0x480
\ Reset value: 0x80000000
\

$00000003 constant RCC_RCC_RCK12SELR_PLL12SRC                       \ Source clock selection for PLL12 Written by software to select the PLL12 source clock. In order to save power when PLL12 is not used, PLL12SRC[1:0] must be set to '1x'. others: No clock send to DIVM1 divider and PLL12
$80000000 constant RCC_RCC_RCK12SELR_PLL12SRCRDY                    \ PLL12 source clock switch status Set and reset by hardware to indicate if the PLL12 clock switch transition has been properly performed.


\
\ @brief RCC PLL3 reference clock selection register
\ Address offset: 0x484
\ Reset value: 0x80000000
\

$00000003 constant RCC_RCC_RCK3SELR_PLL3SRC                         \ Source clock selection for PLL3 Written by software to select the PLL3 clock source. In order to save power, when PLL3 is not used, PLL3SRC[1:0] must be set to '11'.
$80000000 constant RCC_RCC_RCK3SELR_PLL3SRCRDY                      \ PLL3 source clock switch status Set and reset by hardware to indicate if the PLL3 clock switch transition has been properly performed.


\
\ @brief RCC PLL4 reference clock selection register
\ Address offset: 0x488
\ Reset value: 0x80000000
\

$00000003 constant RCC_RCC_RCK4SELR_PLL4SRC                         \ Source clock selection for PLL4 Written by software to select the PLL4 clock source.
$80000000 constant RCC_RCC_RCK4SELR_PLL4SRCRDY                      \ PLL4 source clock switch status Set and reset by hardware to indicate if the PLL4 clock switch transition has been properly performed.


\
\ @brief RCC PLL1 control register
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_PLL1CR_PLLON                             \ PLL1 enable.
$00000002 constant RCC_RCC_PLL1CR_PLL1RDY                           \ PLL1 clock ready flag Set by hardware to indicate that the PLL1 is locked.
$00000004 constant RCC_RCC_PLL1CR_SSCG_CTRL                         \ Spread Spectrum Clock Generator of PLL1 enable Set and reset by software to enable the spread spectrum clock generator of PLL1, in order to reduce the amount of EMI peaks.
$00000010 constant RCC_RCC_PLL1CR_DIVPEN                            \ PLL1 DIVP divider output enable Set and reset by software to enable the pll1_p_ck output of the PLL1. In order to save power, when the pll1_p_ck is not needed, DIVPEN and DIVP must be set to '0'.
$00000020 constant RCC_RCC_PLL1CR_DIVQEN                            \ PLL1 DIVQ divider output enable Set and reset by software to enable the pll1_q_ck output of the PLL1. In order to save power, when the pll1_q_ck is not needed, DIVQEN and DIVQ must be set to '0'.
$00000040 constant RCC_RCC_PLL1CR_DIVREN                            \ PLL1 DIVR divider output enable Set and reset by software to enable the pll1_r_ck output of the PLL1. In order to save power, when the pll1_r_ck is not needed, DIVREN and DIVR must be set to '0'.


\
\ @brief RCC PLL1 configuration register 1
\ Address offset: 0x4A4
\ Reset value: 0x00010031
\

$000001ff constant RCC_RCC_PLL1CFGR1_DIVN                           \ Multiplication factor for PLL1 VCO Written by software to control the multiplication factor of the VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is: 992 to 1800 MHz. VCO output frequency = Fref1_ck x 2 x (DIVN+1), when value 0 has been loaded into FRACV, with: - Valid division ratios for DIVN: between 25 and 100 - The input frequency Fref1_ck between 8 and 16 MHz ... ... Others: wrong configurations
$003f0000 constant RCC_RCC_PLL1CFGR1_DIVM1                          \ Prescaler for PLL1 Set and cleared by software to configure the prescaler of the PLL1. ...


\
\ @brief RCC PLL1 configuration register 2
\ Address offset: 0x4A8
\ Reset value: 0x00010100
\

$0000007f constant RCC_RCC_PLL1CFGR2_DIVP                           \ PLL1 DIVP division factor Written by software to control the frequency of the pll1_p_ck clock. Odd division factors are not recommended due to duty cycle degradation. ...
$00007f00 constant RCC_RCC_PLL1CFGR2_DIVQ                           \ PLL1 DIVQ division factor Written by software to control the frequency of the pll1_q_ck clock. ...
$007f0000 constant RCC_RCC_PLL1CFGR2_DIVR                           \ PLL1 DIVR division factor Written by software to control the frequency of the pll1_r_ck clock. ...


\
\ @brief RCC PLL1 fractional register
\ Address offset: 0x4AC
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL1FRACR_FRACV                          \ Fractional part of the multiplication factor for PLL1 VCO Written by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is: 800 to 1600 MHz VCO output frequency = Fref1_ck x ((DIVN+1) + (FRACV / 8192)), with - DIVN shall be between 4 and 512 - FRACV can be between 0 and 8191 - The input frequency Fref1_ck shall be between 4 and 16 MHz In order to change the FRACV value on-the-fly even if the PLL is enabled, the application has to proceed as follow: - set the bit FRACLE to '0', - write the new fractional value into FRACV, - set the bit FRACLE to '1'.
$00010000 constant RCC_RCC_PLL1FRACR_FRACLE                         \ PLL1 fractional latch enable Set and reset by software to latch the content of FRACV into the Sigma-Delta modulator. In order to latch the FRACV value into the Sigma-Delta modulator, FRACLE must be set to '0', then set to '1': the transition 0 to '1' transfers the content of FRACV into the modulator. Refer to and for additional information on the PLL programming.


\
\ @brief RCC PLL1 clock spreading generator register
\ Address offset: 0x4B0
\ Reset value: 0x00000000
\

$00001fff constant RCC_RCC_PLL1CSGR_MOD_PER                         \ Modulation Period Adjustment for PLL1 Written by software to adjust the modulation period of the clock spreading generator.
$00002000 constant RCC_RCC_PLL1CSGR_TPDFN_DIS                       \ Dithering TPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
$00004000 constant RCC_RCC_PLL1CSGR_RPDFN_DIS                       \ Dithering RPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
$00008000 constant RCC_RCC_PLL1CSGR_SSCG_MODE                       \ Spread spectrum clock generator mode Set and reset by software to select the clock spreading mode.
$7fff0000 constant RCC_RCC_PLL1CSGR_INC_STEP                        \ Modulation Depth Adjustment for PLL1 Written by software to adjust the modulation depth of the clock spreading generator.


\
\ @brief RCC PLL2 control register
\ Address offset: 0x4D0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_PLL2CR_PLLON                             \ PLL2 enable Set and cleared by software to enable the PLL2.
$00000002 constant RCC_RCC_PLL2CR_PLL2RDY                           \ PLL2 clock ready flag Set by hardware to indicate that the PLL2 is locked.
$00000004 constant RCC_RCC_PLL2CR_SSCG_CTRL                         \ Clock Spreading Generator of PLL2 enable Set and reset by software to enable the clock spreading generator of PLL2, in order to reduce the amount of EMI peaks.
$00000010 constant RCC_RCC_PLL2CR_DIVPEN                            \ PLL2 DIVP divider output enable Set and reset by software to enable the pll2_p_ck output of the PLL2. In order to save power, when the pll2_p_ck is not needed, DIVPEN and DIVP must be set to '0'.
$00000020 constant RCC_RCC_PLL2CR_DIVQEN                            \ PLL2 DIVQ divider output enable Set and reset by software to enable the pll2_q_ck output of the PLL2. In order to save power, when the pll2_q_ck is not needed, DIVQEN and DIVQ must be set to '0'.
$00000040 constant RCC_RCC_PLL2CR_DIVREN                            \ PLL2 DIVR divider output enable Set and reset by software to enable the pll2_r_ck output of the PLL2. In order to save power, when the pll2_r_ck is not needed, DIVREN and DIVR must be set to '0'.


\
\ @brief RCC PLL2 configuration register 1
\ Address offset: 0x4D4
\ Reset value: 0x00010063
\

$000001ff constant RCC_RCC_PLL2CFGR1_DIVN                           \ Multiplication factor for PLL2 VCO Written by software to control the multiplication factor of the VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is: 800 to 1600 MHz. VCO output frequency = Fref2_ck x (DIVN+1), when value 0 has been loaded into FRACV, with: - Valid division ratios for DIVN: between 25 and 100 - The input frequency Fref2_ck between 8 and 16 MHz Others: wrong configurations ... ...
$003f0000 constant RCC_RCC_PLL2CFGR1_DIVM2                          \ Prescaler for PLL2 Set and cleared by software to configure the prescaler of the PLL2. ...


\
\ @brief RCC PLL2 configuration register 2
\ Address offset: 0x4D8
\ Reset value: 0x00010101
\

$0000007f constant RCC_RCC_PLL2CFGR2_DIVP                           \ PLL2 DIVP division factor Written by software to control the frequency of the pll2_p_ck clock. ...
$00007f00 constant RCC_RCC_PLL2CFGR2_DIVQ                           \ PLL2 DIVQ division factor Written by software to control the frequency of the pll2_q_ck clock. ...
$007f0000 constant RCC_RCC_PLL2CFGR2_DIVR                           \ PLL2 DIVR division factor Written by software to control the frequency of the pll2_r_ck clock. ...


\
\ @brief RCC PLL2 fractional register
\ Address offset: 0x4DC
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL2FRACR_FRACV                          \ Fractional part of the multiplication factor for PLL2 VCO Written by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is: 800 to 1600 MHz VCO output frequency = Fref2_ck x ((DIVN+1) + (FRACV / 8192)), with - DIVN shall be between 4 and 512 - FRACV can be between 0 and 8191 - The input frequency Fref2_ck shall be between 4 and 16 MHz In order to change the FRACV value on-the-fly even if the PLL is enabled, the application has to proceed as follow: - set the bit FRACLE to '0', - write the new fractional value into FRACV, - set the bit FRACLE to '1'.
$00010000 constant RCC_RCC_PLL2FRACR_FRACLE                         \ PLL2 fractional latch enable Set and reset by software to latch the content of FRACV into the Sigma-Delta modulator. In order to latch the FRACV value into the Sigma-Delta modulator, FRACLE must be set to '0', then set to '1': the transition 0 to '1' transfers the content of FRACV into the modulator. Refer to and for additional information on the PLL programming.


\
\ @brief RCC PLL2 clock spreading generator register
\ Address offset: 0x4E0
\ Reset value: 0x00000000
\

$00001fff constant RCC_RCC_PLL2CSGR_MOD_PER                         \ Modulation Period Adjustment for PLL2 Written by software to adjust the modulation period of the clock spreading generator.
$00002000 constant RCC_RCC_PLL2CSGR_TPDFN_DIS                       \ Dithering TPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
$00004000 constant RCC_RCC_PLL2CSGR_RPDFN_DIS                       \ Dithering RPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
$00008000 constant RCC_RCC_PLL2CSGR_SSCG_MODE                       \ Spread spectrum clock generator mode Set and reset by software to select the clock spreading mode.
$7fff0000 constant RCC_RCC_PLL2CSGR_INC_STEP                        \ Modulation Depth Adjustment for PLL2 Written by software to adjust the modulation depth of the clock spreading generator.


\
\ @brief RCC PLL3 control register
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_PLL3CR_PLLON                             \ PLL3 enable
$00000002 constant RCC_RCC_PLL3CR_PLL3RDY                           \ PLL3 clock ready flag Set by hardware to indicate that the PLL3 is locked.
$00000004 constant RCC_RCC_PLL3CR_SSCG_CTRL                         \ Clock Spreading Generator of PLL3 enable Set and reset by software to enable the clock spreading generator of PLL3, in order to reduce the amount of EMI peaks.
$00000010 constant RCC_RCC_PLL3CR_DIVPEN                            \ PLL3 DIVP divider output enable Set and reset by software to enable the pll3_p_ck output of the PLL3. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll3_p_ck is not needed, DIVPEN and DIVP must be set to '0'.
$00000020 constant RCC_RCC_PLL3CR_DIVQEN                            \ PLL3 DIVQ divider output enable Set and reset by software to enable the pll3_q_ck output of the PLL3. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll3_q_ck is not needed, DIVQEN and DIVQ must be set to '0'.
$00000040 constant RCC_RCC_PLL3CR_DIVREN                            \ PLL3 DIVR divider output enable Set and reset by software to enable the pll3_r_ck output of the PLL3. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll3_r_ck is not needed, DIVREN and DIVR must be set to '0'.


\
\ @brief RCC PLL3 configuration register 1
\ Address offset: 0x504
\ Reset value: 0x00010031
\

$000001ff constant RCC_RCC_PLL3CFGR1_DIVN                           \ Multiplication factor for PLL3 VCO Written by software to control the multiplication factor of the VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is between 400 and 800 MHz. VCO output frequency = Fref3_ck x (DIVN+1), when value 0 has been loaded into FRACV, with: - Valid division ratios for DIVN: between 25 and 200 - The input frequency Fref3_ck between 4 and 16 MHz ... ... Others: wrong configurations
$003f0000 constant RCC_RCC_PLL3CFGR1_DIVM3                          \ Prescaler for PLL3 Set and cleared by software to configure the prescaler of the PLL3. ...
$03000000 constant RCC_RCC_PLL3CFGR1_IFRGE                          \ PLL3 input frequency range Written by software to select the proper reference frequency range used for PLL3. x0: The PLL3 input (ref3_ck) clock range frequency is between 4 and 8 MHz (default after reset) x1: The PLL3 input (ref3_ck) clock range frequency is between 8 and 16 MHz. Note that if ref3_ck is equal to 8Â MHz, it is recommended to set IFRGE = 'x1â


\
\ @brief RCC PLL3 configuration register 2
\ Address offset: 0x508
\ Reset value: 0x00010101
\

$0000007f constant RCC_RCC_PLL3CFGR2_DIVP                           \ PLL3 DIVP division factor Written by software to control the frequency of the pll3_p_ck clock. ...
$00007f00 constant RCC_RCC_PLL3CFGR2_DIVQ                           \ PLL3 DIVQ division factor Written by software to control the frequency of the pll3_q_ck clock. ...
$007f0000 constant RCC_RCC_PLL3CFGR2_DIVR                           \ PLL3 DIVR division factor Written by software to control the frequency of the pll3_r_ck clock. ...


\
\ @brief RCC PLL3 Fractional register
\ Address offset: 0x50C
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL3FRACR_FRACV                          \ Fractional part of the multiplication factor for PLL3 VCO Written by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is between 400 and 800 MHz. VCO output frequency = Fref3_ck x ((DIVN+1) + (FRACV / 8192)), with - DIVN shall be between 4 and 512 - FRACV can be between 0 and 8191 - The input frequency Fref3_ck shall be between 1 and 16 MHz In order to change the FRACV value on-the-fly even if the PLL is enabled, the application has to proceed as follow: - set the bit FRACLE to '0', - write the new fractional value into FRACV, - set the bit FRACLE to '1'.
$00010000 constant RCC_RCC_PLL3FRACR_FRACLE                         \ PLL3 fractional latch enable Set and reset by software to latch the content of FRACV into the Sigma-Delta modulator. In order to latch the FRACV value into the Sigma-Delta modulator, FRACLE must be set to '0', then set to '1': the transition 0 to '1' transfers the content of FRACV into the modulator. Refer to and for additional information on the PLL programming.


\
\ @brief RCC PLL3 clock spreading generator register
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$00001fff constant RCC_RCC_PLL3CSGR_MOD_PER                         \ Modulation Period Adjustment for PLL3 Written by software to adjust the modulation period of the clock spreading generator.
$00002000 constant RCC_RCC_PLL3CSGR_TPDFN_DIS                       \ Dithering TPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
$00004000 constant RCC_RCC_PLL3CSGR_RPDFN_DIS                       \ Dithering RPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
$00008000 constant RCC_RCC_PLL3CSGR_SSCG_MODE                       \ Spread spectrum clock generator mode Set and reset by software to select the clock spreading mode.
$7fff0000 constant RCC_RCC_PLL3CSGR_INC_STEP                        \ Modulation Depth Adjustment for PLL3 Written by software to adjust the modulation depth of the clock spreading generator.


\
\ @brief RCC PLL4 control register
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_PLL4CR_PLLON                             \ PLL4 enable
$00000002 constant RCC_RCC_PLL4CR_PLL4RDY                           \ PLL4 clock ready flag Set by hardware to indicate that the PLL4 is locked.
$00000004 constant RCC_RCC_PLL4CR_SSCG_CTRL                         \ Clock Spreading Generator of PLL4 enable Set and reset by software to enable the clock spreading generator of PLL4, in order to reduce the amount of EMI peaks.
$00000010 constant RCC_RCC_PLL4CR_DIVPEN                            \ PLL4 DIVP divider output enable Set and reset by software to enable the pll4_p_ck output of the PLL4. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll4_p_ck is not needed, DIVPEN must be set to '0'.
$00000020 constant RCC_RCC_PLL4CR_DIVQEN                            \ PLL4 DIVQ divider output enable Set and reset by software to enable the pll4_q_ck output of the PLL4. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll4_q_ck is not needed, DIVQEN must be set to '0'.
$00000040 constant RCC_RCC_PLL4CR_DIVREN                            \ PLL4 DIVR divider output enable Set and reset by software to enable the pll4_r_ck output of the PLL4. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll4_r_ck is not needed, DIVREN must be set to '0'.


\
\ @brief RCC PLL4 configuration register 1
\ Address offset: 0x524
\ Reset value: 0x00010031
\

$000001ff constant RCC_RCC_PLL4CFGR1_DIVN                           \ Multiplication factor for PLL4 VCO Written by software to control the multiplication factor of the VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is between 400 and 800 MHz. VCO output frequency = Fref4_ck x (DIVN+1), when value 0 has been loaded into FRACV, with: - Valid division ratios for DIVN: between 25 and 200 - The input frequency Fref4_ck between 4 and 16 MHz ... ... Others: wrong configurations
$003f0000 constant RCC_RCC_PLL4CFGR1_DIVM4                          \ Prescaler for PLL4 Set and cleared by software to configure the prescaler of the PLL4. ...
$03000000 constant RCC_RCC_PLL4CFGR1_IFRGE                          \ PLL4 input frequency range Written by software to select the proper reference frequency range used for PLL4. x0: The PLL4 input (ref4_ck) clock range frequency is between 4 and 8 MHz (default after reset) x1: The PLL4 input (ref4_ck) clock range frequency is between 8 and 16 MHz Note that if ref3_ck is equal to 8Â MHz, it is recommended to set IFRGE = 'x1â


\
\ @brief RCC PLL4 configuration register 2
\ Address offset: 0x528
\ Reset value: 0x00000000
\

$0000007f constant RCC_RCC_PLL4CFGR2_DIVP                           \ PLL4 DIVP division factor Written by software to control the frequency of the pll4_p_ck clock. ...
$00007f00 constant RCC_RCC_PLL4CFGR2_DIVQ                           \ PLL4 DIVQ division factor Written by software to control the frequency of the pll4_q_ck clock. ...
$007f0000 constant RCC_RCC_PLL4CFGR2_DIVR                           \ PLL4 DIVR division factor Written by software to control the frequency of the pll4_r_ck clock. ...


\
\ @brief RCC PLL4 fractional register
\ Address offset: 0x52C
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL4FRACR_FRACV                          \ Fractional part of the multiplication factor for PLL4 VCO Written by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL4 VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is between 400 and 800 MHz. VCO output frequency = Fref4_ck x ((DIVN+1) + (FRACV / 8192)), with - DIVN shall be between 4 and 512 - FRACV can be between 0 and 8191 - The input frequency Fref4_ck shall be between 1 and 16 MHz In order to change the FRACV value on-the-fly even if the PLL is enabled, the application has to proceed as follow: - set the bit FRACLE to '0', - write the new fractional value into FRACV, - set the bit FRACLE to '1'.
$00010000 constant RCC_RCC_PLL4FRACR_FRACLE                         \ PLL4 fractional latch enable Set and reset by software to latch the content of FRACV into the Sigma-Delta modulator. In order to latch the FRACV value into the Sigma-Delta modulator, FRACLE must be set to '0', then set to '1': the transition 0 to '1' transfers the content of FRACV into the modulator. Refer to Section: Refer to and dividers for additional information.


\
\ @brief RCC PLL4 clock spreading generator register
\ Address offset: 0x530
\ Reset value: 0x00000000
\

$00001fff constant RCC_RCC_PLL4CSGR_MOD_PER                         \ Modulation Period Adjustment for PLL4 Written by software to adjust the modulation period of the clock spreading generator.
$00002000 constant RCC_RCC_PLL4CSGR_TPDFN_DIS                       \ Dithering TPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
$00004000 constant RCC_RCC_PLL4CSGR_RPDFN_DIS                       \ Dithering RPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
$00008000 constant RCC_RCC_PLL4CSGR_SSCG_MODE                       \ Spread spectrum clock generator mode Set and reset by software to select the clock spreading mode.
$7fff0000 constant RCC_RCC_PLL4CSGR_INC_STEP                        \ Modulation Depth Adjustment for PLL4 Written by software to adjust the modulation depth of the clock spreading generator.


\
\ @brief RCC MPU clock selection register
\ Address offset: 0x540
\ Reset value: 0x80000000
\

$00000003 constant RCC_RCC_MPCKSELR_MPUSRC                          \ MPU clock switch Written by software to select the MPU sub-system clock source (mpuss_ck). Note that MPUDIV is disabled if MPUSRC[1:0] is different from '11'. Be sure that MPUDIV is different from '000' before setting MPUSRC to '11'.
$80000000 constant RCC_RCC_MPCKSELR_MPUSRCRDY                       \ MPU clock switch status Set and reset by hardware to indicate if the MPU clock switch transition has been properly performed.


\
\ @brief RCC AXI sub-system clock selection register.
\ Address offset: 0x544
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_ASSCKSELR_AXISSRC                        \ AXI sub-system clock switch Written by software to select the AXI sub-system clock source (axiss_ck). others: axiss_ck is gated
$80000000 constant RCC_RCC_ASSCKSELR_AXISSRCRDY                     \ AXI sub-system clock switch status Set and reset by hardware to indicate if the AXI clock switch transition has been properly performed.


\
\ @brief RCC MLAHB sub-system clock selection register
\ Address offset: 0x548
\ Reset value: 0x80000000
\

$00000003 constant RCC_RCC_MSSCKSELR_MLAHBSSRC                      \ MLAHB sub-system clock switch Written by software to select the MLAHB sub-system clock source (mlahbss_ck). Reset by hardware in order to select hsi_ck when the system exits from one of the Stop modes.
$80000000 constant RCC_RCC_MSSCKSELR_MLAHBSSRCRDY                   \ MLAHB sub-system clock switch status Set and reset by hardware to indicate if the MLAHB clock switch transition has been properly performed.


\
\ @brief RCC common peripheral kernel clock selection register
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CPERCKSELR_CKPERSRC                      \ Oscillator selection for kernel clock Set and cleared by software.


\
\ @brief RCC RTC clock division register
\ Address offset: 0x560
\ Reset value: 0x00000000
\

$0000003f constant RCC_RCC_RTCDIVR_RTCDIV                           \ HSE division factor for RTC clock Set and cleared by software to divide the HSE to generate a clock for RTC. Caution: The software has to set these bits correctly to ensure that the clock supplied to the RTC is lower than 4 MHz. These bits must be configured if needed before selecting the RTC clock source. Note that when the RTCSRC is different from 3, this divider is disabled (does not provide clock). ...


\
\ @brief RCC MPU clock divider register
\ Address offset: 0x564
\ Reset value: 0x80000001
\

$0000000f constant RCC_RCC_MPCKDIVR_MPUDIV                          \ MPU Core clock divider Written by software to control the MPU clock division factor when the MPUSRC is set to position 3. It is possible to change this division ratio on-the-fly. It impacts only the frequency of the MPU clock. The clocks are divided with the new prescaler factor, from 1 to 16 pll1_p_ck cycles after MPUDIV update. The application can check if the new division factor is taken into account by reading back the MPUDIVRDY flag. Note that this divider is disabled if MPUSRC[1:0] is different from '11'. 0x<n>: The mpuss_ck is equal to pll1_p_ck divided by 0x<n>+1
$80000000 constant RCC_RCC_MPCKDIVR_MPUDIVRDY                       \ MPU sub-system clock divider status Set and reset by hardware to indicate if the new division factor is taken into account. This bit significant only when MPUSRC[1:0] = '11'.


\
\ @brief RCC AXI clock divider register
\ Address offset: 0x568
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_AXIDIVR_AXIDIV                           \ AXI, AHB5 and AHB6 clock divider Written by software to control the AXI, AHB5 and AHB6 clock division factor. It is possible to change this division ratio on-the-fly. It impacts the frequency of AXI, APB4, APB5 AHB5 and AHB6 clocks. The clocks are divided with the new prescaler factor, from 1 to 4 axiss_ck cycles after AXIDIV update. The application can check if the new division factor is taken into account by reading back the AXIDIVRDY flag. others: axiss_ck / 4
$80000000 constant RCC_RCC_AXIDIVR_AXIDIVRDY                        \ AXI sub-system clock divider status Set and reset by hardware to indicate if the new division factor is taken into account.


\
\ @brief RCC MLAHB clock divider register
\ Address offset: 0x56C
\ Reset value: 0x80000000
\

$0000000f constant RCC_RCC_MLAHBDIVR_MLAHBDIV                       \ MLAHB clock divider Written by software to control the MLAHB clock division factor. Changing this division ratio has an impact on the frequency of MLAHB clock, and all bus matrix clocks. The clocks are divided with the new prescaler factor, from 1 to 512 cycles of mlahbss_ck, after MLAHBDIV update. The application can check if the new division factor is taken into account by reading back the MLAHBDIVRDY flag. others: mlahbss_ck divided by 512
$80000000 constant RCC_RCC_MLAHBDIVR_MLAHBDIVRDY                    \ MLAHB clock prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.


\
\ @brief RCC APB1 clock divider register
\ Address offset: 0x570
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_APB1DIVR_APB1DIV                         \ APB1 clock divider Written by software to control the APB1 clock division factor. The APB1 peripheral clock is divided with the new prescaler factor, from 1 to 16 mlhclk cycles after APB1DIV update. The application can check if the new division factor is taken into account by reading back the APB1DIVRDY flag. others: Not allowed
$80000000 constant RCC_RCC_APB1DIVR_APB1DIVRDY                      \ APB1 clock prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.


\
\ @brief RCC APB2 clock divider register
\ Address offset: 0x574
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_APB2DIVR_APB2DIV                         \ APB2 clock divider Written by software to control the APB2 clock division factor. The APB2 clock is divided with the new prescaler factor, from 1 to 16 mlhclk cycles after APB2DIV update. The application can check if the new division factor is taken into account by reading back the APB2DIVRDY flag. others: Not allowed
$80000000 constant RCC_RCC_APB2DIVR_APB2DIVRDY                      \ APB2 clock prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.


\
\ @brief RCC APB3 clock divider register
\ Address offset: 0x578
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_APB3DIVR_APB3DIV                         \ APB3 clock divider Written by software to control the APB3 clock division factor. The APB3 clock is divided by this new prescaler factor, from 1 to 16 hclk cycles after APB3DIV update. The application can check if the new division factor is taken into account by reading back the APB3DIVRDY flag. others: hclk / 16
$80000000 constant RCC_RCC_APB3DIVR_APB3DIVRDY                      \ APB3 clock prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.


\
\ @brief RCC APB4 clock divider register.
\ Address offset: 0x57C
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_APB4DIVR_APB4DIV                         \ APB4 clock divider Written by software to control the APB4 clock division factor. It is possible to change this division ratio on-the-fly. It impacts only the frequency of APB4 clock. The clocks are divided with the new prescaler factor, from 1 to 16 aclk cycles after APB4DIV update. The application can check if the new division factor is taken into account by reading back the APB4DIVRDY flag. others: aclk / 16
$80000000 constant RCC_RCC_APB4DIVR_APB4DIVRDY                      \ APB4 clock divider status Set and reset by hardware to indicate if the new division factor is taken into account.


\
\ @brief RCC APB5 clock divider register
\ Address offset: 0x580
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_APB5DIVR_APB5DIV                         \ APB5 clock divider Written by software to control the APB5 clock division factor. It is possible to change this division ratio on-the-fly. It impacts only the frequency of APB5 clock. The clocks are divided with the new prescaler factor, from 1 to 16 aclk cycles after APB5DIV update. The application can check if the new division factor is taken into account by reading the APB5DIVRDY flag. others: aclk / 16
$80000000 constant RCC_RCC_APB5DIVR_APB5DIVRDY                      \ APB5 clock divider status Set and reset by hardware to indicate if the new division factor is taken into account.


\
\ @brief RCC APB6 clock divider register
\ Address offset: 0x584
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_APB6DIVR_APB6DIV                         \ APB6 clock divider Written by software to control the APB6 clock division factor. It is possible to change this division ratio on-the-fly. It impacts only the frequency of APB6 clock. The clocks are divided with the new prescaler factor, from 1 to 16 aclk cycles after APB6DIV update. The application can check if the new division factor is taken into account by reading the APB6DIVRDY flag. others: aclk / 16
$80000000 constant RCC_RCC_APB6DIVR_APB6DIVRDY                      \ APB6 clock divider status Set and reset by hardware to indicate if the new division factor is taken into account.


\
\ @brief RCC APB1 timers group1 prescaler register.
\ Address offset: 0x5A0
\ Reset value: 0x80000000
\

$00000001 constant RCC_RCC_TIMG1PRER_TIMG1PRE                       \ Timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB1 domain. Refer to .
$80000000 constant RCC_RCC_TIMG1PRER_TIMG1PRERDY                    \ Timers clocks prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.


\
\ @brief RCC APB2 timers group2 prescaler register
\ Address offset: 0x5A4
\ Reset value: 0x80000000
\

$00000001 constant RCC_RCC_TIMG2PRER_TIMG2PRE                       \ Timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB2 domain. Refer to .
$80000000 constant RCC_RCC_TIMG2PRER_TIMG2PRERDY                    \ Timers clocks prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.


\
\ @brief RCC APB6 timers group3 prescaler register
\ Address offset: 0x5A8
\ Reset value: 0x80000000
\

$00000001 constant RCC_RCC_TIMG3PRER_TIMG3PRE                       \ Timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB6 domain. Refer to .
$80000000 constant RCC_RCC_TIMG3PRER_TIMG3PRERDY                    \ Timers clocks prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.


\
\ @brief RCC DDR interface control register
\ Address offset: 0x5C0
\ Reset value: 0x000FD022
\

$00000001 constant RCC_RCC_DDRITFCR_DDRC1EN                         \ DDRC port 1 peripheral clocks enable If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of ddrc_ker_ckg, aclk1_ddrc and pclk4_ddrc clocks.
$00000002 constant RCC_RCC_DDRITFCR_DDRC1LPEN                       \ DDRC port 1 peripheral clocks enable during CSleep mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of ddrc_ker_ckg, aclk1_ddrc and pclk4_ddrc in CSleep.
$00000010 constant RCC_RCC_DDRITFCR_DDRPHYCEN                       \ DDRPHYC peripheral clocks enable If DDRPHYC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of dphy_ker_ck and pclk4_dphy
$00000020 constant RCC_RCC_DDRITFCR_DDRPHYCLPEN                     \ DDRPHYC peripheral clocks enable during CSleep mode If DDRPHYC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of dphy_ker_ck and pclk4_dphy in CSleep
$00000040 constant RCC_RCC_DDRITFCR_DDRCAPBEN                       \ DDRC APB clock enable If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of pclk4_ddrc clock.
$00000080 constant RCC_RCC_DDRITFCR_DDRCAPBLPEN                     \ DDRC APB clock enable during CSleep mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of pclk4_ddrc clock during CSleep mode.
$00000100 constant RCC_RCC_DDRITFCR_AXIDCGEN                        \ AXIDCG enable during MPU CRun mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. When the dynamic clock gating is disabled, the clock is always provided to the DDRC if provided by the RCC.
$00000200 constant RCC_RCC_DDRITFCR_DDRPHYCAPBEN                    \ DDRPHYC APB clock enable If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of pclk4_dphy clock.
$00000400 constant RCC_RCC_DDRITFCR_DDRPHYCAPBLPEN                  \ DDRPHYC APB clock enable during CSleep mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of pclk4_dphy clock during CSleep mode.
$00003800 constant RCC_RCC_DDRITFCR_KERDCG_DLY                      \ AXIDCG delay If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. It represents the delay between the falling edge of the cactive_ddrc signal and the moment where the KERDCG will gate the ddrc_ker_ckg. ...
$00004000 constant RCC_RCC_DDRITFCR_DDRCAPBRST                      \ DDRC APB interface reset If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
$00008000 constant RCC_RCC_DDRITFCR_DDRCAXIRST                      \ DDRC AXI interface reset If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
$00010000 constant RCC_RCC_DDRITFCR_DDRCORERST                      \ DDRC core reset If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
$00020000 constant RCC_RCC_DDRITFCR_DPHYAPBRST                      \ DDRPHYC APB interface reset If DDRPHYC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
$00040000 constant RCC_RCC_DDRITFCR_DPHYRST                         \ DDRPHYC reset If DDRPHYC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
$00080000 constant RCC_RCC_DDRITFCR_DPHYCTLRST                      \ DDRPHYC Control reset If DDRPHYC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
$00700000 constant RCC_RCC_DDRITFCR_DDRCKMOD                        \ RCC mode for DDR clock control If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. This mode can be used when the application wants to maintain a clock to the DLLs in order to avoid the re-lock sequences. In this mode it is recommended to have DDRCxEN = DDRCxLPEN = DDRPHYCEN = DDRPHYCLPEN = '1'. This mode can be used when the DLLs are in bypass. In this mode it is recommended to have DDRCxEN = DDRCxLPEN = DDRPHYCEN = DDRPHYCLPEN = '1'. This mode can be used when the application wants to maintain a clock to the DLLs. In this mode it is recommended to have DDRCxEN = DDRCxLPEN = DDRPHYCEN = DDRPHYCLPEN = '1'. This mode can be used when the DLLs are in bypass. In this mode it is recommended to have DDRCxEN = DDRCxLPEN = DDRPHYCEN = DDRPHYCLPEN = '1'. other: reserved
$00800000 constant RCC_RCC_DDRITFCR_GSKPMOD                         \ Glitch Skipper (GSKP) Mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
$01000000 constant RCC_RCC_DDRITFCR_GSKPCTRL                        \ Glitch skipper (GSKP) control If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This has effect only if GSKPMOD = '0'.
$0e000000 constant RCC_RCC_DDRITFCR_DFILP_WIDTH                     \ Minimum duration of low-power request command If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. The low power request duration must always be bigger or equal to 1 microsecond. If this duration is not respected, the DDR interface behavior is not guaranteed. The application has to program properly DFILP_WIDTH in order to ensure a delay bigger or equal to 1 microsecond. Note that the delay is also dependent of the frequency of the dphy_ker_ck clock. Others: Forces a delay of 544 x Tdphy_ker_ck to be used when Fdphy_ker_ck is between 410 and 533MHz
$f0000000 constant RCC_RCC_DDRITFCR_GSKP_DUR                        \ Glitch skipper duration in automatic mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. This field allow the application to define the amount of time where the glitch skipper is providing the clock dphy_ker_ck instead of the clock ddrc_ker_ck to the DDRC block. This feature is only working when the glitch skipper is set in automatic mode (GSKPMOD = '1'). This delay is equal to (GSKP_DUR + 1) x 32 x Tdphy_ker_ck ...


\
\ @brief RCC I2C1 and I2C2 kernel clock selection register
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_I2C12CKSELR_I2C12SRC                     \ I2C1 and I2C2 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC I2C3, I2C4 and I2C5 kernel clock selection register.
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_I2C345CKSELR_I2C3SRC                     \ I2C3 kernel clock source selection If I2C3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
$00000038 constant RCC_RCC_I2C345CKSELR_I2C4SRC                     \ I2C4 kernel clock source selection If I2C4 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
$000001c0 constant RCC_RCC_I2C345CKSELR_I2C5SRC                     \ I2C5 kernel clock source selection If I2C5 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC SPI/I2S1 kernel clock selection register
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SPI2S1CKSELR_SPI1SRC                     \ SPI/I2S1 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC SPI/I2S2 and SPI/I2S3 kernel clock selection register
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SPI2S23CKSELR_SPI23SRC                   \ SPI/I2S2 and SPI/I2S3 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC SPI/I2S4 and SPI5 kernel clock selection register
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SPI45CKSELR_SPI4SRC                      \ SPI/I2S4 kernel clock source selection If SPI/I2S4 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
$00000038 constant RCC_RCC_SPI45CKSELR_SPI5SRC                      \ SPI5 kernel clock source selection If SPI5 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC USART1 and USART2 kernel clock selection register
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_UART12CKSELR_UART1SRC                    \ USART1 kernel clock source selection If USART1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
$00000038 constant RCC_RCC_UART12CKSELR_UART2SRC                    \ USART2 kernel clock source selection If USART2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC USART3 and UART5 kernel clock selection register
\ Address offset: 0x618
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_UART35CKSELR_UART35SRC                   \ USART3 and UART5 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC UART4 kernel clock selection register
\ Address offset: 0x61C
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_UART4CKSELR_UART4SRC                     \ UART4 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC USART6 kernel clock selection register
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_UART6CKSELR_UART6SRC                     \ USART6 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC UART7 and UART8 kernel clock selection register
\ Address offset: 0x624
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_UART78CKSELR_UART78SRC                   \ UART7 and UART8 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC LPTIM1 kernel clock selection register
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_LPTIM1CKSELR_LPTIM1SRC                   \ LPTIM1 kernel clock source selection Written by software. others: the kernel clock is disabled


\
\ @brief RCC LPTIM2 and LPTIM3 kernel clock selection register
\ Address offset: 0x62C
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_LPTIM23CKSELR_LPTIM2SRC                  \ LPTIM2 kernel clock source selection If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled
$00000038 constant RCC_RCC_LPTIM23CKSELR_LPTIM3SRC                  \ LPTIM3 kernel clock source selection If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled


\
\ @brief RCC LPTIM4 and LPTIM5 kernel clock selection register
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_LPTIM45CKSELR_LPTIM45SRC                 \ LPTIM4 and LPTIM5 kernel clock source selection Written by software. others: the kernel clock is disabled


\
\ @brief RCC SAI1 kernel clock selection register
\ Address offset: 0x634
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SAI1CKSELR_SAI1SRC                       \ SAI1 and DFSDM kernel clock source selection Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC SAI2 kernel clock selection register
\ Address offset: 0x638
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SAI2CKSELR_SAI2SRC                       \ SAI2 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC FDCAN kernel clock selection register
\ Address offset: 0x63C
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_FDCANCKSELR_FDCANSRC                     \ FDCAN kernel clock source selection Written by software.


\
\ @brief RCC SPDIFRX kernel clock selection register
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_SPDIFCKSELR_SPDIFSRC                     \ SPDIFRX kernel clock source selection Written by software. others: reserved, the kernel clock is disabled


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the (AHB2) ADC1 and ADC2 blocks. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
\ Address offset: 0x644
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_ADC12CKSELR_ADC1SRC                      \ ADC1 kernel clock source selection If ADC1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled
$0000000c constant RCC_RCC_ADC12CKSELR_ADC2SRC                      \ ADC2 kernel clock source selection If ADC2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the (AHB6) SDMMC1 and SDMMC2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
\ Address offset: 0x648
\ Reset value: 0x00000003
\

$00000007 constant RCC_RCC_SDMMC12CKSELR_SDMMC1SRC                  \ SDMMC1 kernel clock source selection If SDMMC1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
$00000038 constant RCC_RCC_SDMMC12CKSELR_SDMMC2SRC                  \ SDMMC2 kernel clock source selection If SDMMC2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the ETH1 and ETH2 blocks. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_ETH12CKSELR_ETH1SRC                      \ ETH1 kernel clock source selection If ETH1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled
$000000f0 constant RCC_RCC_ETH12CKSELR_ETH1PTPDIV                   \ ETH1 clock divider for Precision Time Protocol (PTP) If ETH1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software to configure the divider value. ...
$00000300 constant RCC_RCC_ETH12CKSELR_ETH2SRC                      \ ETH2 kernel clock source selection If ETH2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled
$0000f000 constant RCC_RCC_ETH12CKSELR_ETH2PTPDIV                   \ ETH2 clock divider for Precision Time Protocol (PTP) If ETH2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software to configure the divider value. ...


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the USBPHY PLL of the USB Host (USBH) and the USB On-The-Go (USBO). It also controls the pre-divider for the reference clock for the USBPHY. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_USBCKSELR_USBPHYSRC                      \ USB PHY kernel clock source selection If USBPHY block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. other: clock disabled
$00000010 constant RCC_RCC_USBCKSELR_USBOSRC                        \ USB OTG kernel clock source selection If USBO block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software.


\
\ @brief If (AHB6) QUADSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the QUADSPI. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_QSPICKSELR_QSPISRC                       \ QUADSPI kernel clock source selection Written by software.


\
\ @brief If (AHB6) FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the FMC block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
\ Address offset: 0x658
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_FMCCKSELR_FMCSRC                         \ FMC kernel clock source selection Written by software.


\
\ @brief If (AHB5) RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the RNG1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
\ Address offset: 0x65C
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_RNG1CKSELR_RNG1SRC                       \ RNG1 kernel clock source selection Written by software.


\
\ @brief If (APB5) STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. STGEN is a dual APB interface IP, with STGENC APB5 controller part which may be secure or non-secure depending on the corresponding DECPROT[1]. Its other STGENRO APB4 read-only interface is non-secure. This register is used to select the peripheral clock for the STGEN block. Note that this clock is used to provide a time reference for the application. Refer to SectionÂ : Clock enabling delays.
\ Address offset: 0x660
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_STGENCKSELR_STGENSRC                     \ Oscillator selection for kernel clock Set and cleared by software. others: Clock disabled


\
\ @brief If (APB4) DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the DCMIPP block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_DCMIPPCKSELR_DCMIPPSRC                   \ DCMIPP kernel clock source selection Written by software.


\
\ @brief If (AHB5) SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the SAES block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
\ Address offset: 0x668
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_SAESCKSELR_SAESSRC                       \ SAES kernel clock source selection Written by software.


\
\ @brief This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
\ Address offset: 0x6A0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1RSTSETR_TIM2RST                      \ TIM2 block reset Set by software.
$00000002 constant RCC_RCC_APB1RSTSETR_TIM3RST                      \ TIM3 block reset Set by software.
$00000004 constant RCC_RCC_APB1RSTSETR_TIM4RST                      \ TIM4 block reset Set by software.
$00000008 constant RCC_RCC_APB1RSTSETR_TIM5RST                      \ TIM5 block reset Set by software.
$00000010 constant RCC_RCC_APB1RSTSETR_TIM6RST                      \ TIM6 block reset Set by software.
$00000020 constant RCC_RCC_APB1RSTSETR_TIM7RST                      \ TIM7 block reset Set by software.
$00000200 constant RCC_RCC_APB1RSTSETR_LPTIM1RST                    \ LPTIM1 block reset Set by software.
$00000800 constant RCC_RCC_APB1RSTSETR_SPI2RST                      \ SPI/I2S2 block reset Set by software.
$00001000 constant RCC_RCC_APB1RSTSETR_SPI3RST                      \ SPI3 block reset Set by software.
$00008000 constant RCC_RCC_APB1RSTSETR_USART3RST                    \ USART3 block reset Set by software.
$00010000 constant RCC_RCC_APB1RSTSETR_UART4RST                     \ UART4 block reset Set by software.
$00020000 constant RCC_RCC_APB1RSTSETR_UART5RST                     \ UART5 block reset Set by software.
$00040000 constant RCC_RCC_APB1RSTSETR_UART7RST                     \ UART7 block reset Set by software.
$00080000 constant RCC_RCC_APB1RSTSETR_UART8RST                     \ UART8 block reset Set by software.
$00200000 constant RCC_RCC_APB1RSTSETR_I2C1RST                      \ I2C1 block reset Set by software.
$00400000 constant RCC_RCC_APB1RSTSETR_I2C2RST                      \ I2C2 block reset Set by software.
$04000000 constant RCC_RCC_APB1RSTSETR_SPDIFRST                     \ SPDIFRX block reset Set by software.


\
\ @brief This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
\ Address offset: 0x6A4
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1RSTCLRR_TIM2RST                      \ TIM2 block reset Cleared by software.
$00000002 constant RCC_RCC_APB1RSTCLRR_TIM3RST                      \ TIM3 block reset Cleared by software.
$00000004 constant RCC_RCC_APB1RSTCLRR_TIM4RST                      \ TIM4 block reset Cleared by software.
$00000008 constant RCC_RCC_APB1RSTCLRR_TIM5RST                      \ TIM5 block reset Cleared by software.
$00000010 constant RCC_RCC_APB1RSTCLRR_TIM6RST                      \ TIM6 block reset Cleared by software.
$00000020 constant RCC_RCC_APB1RSTCLRR_TIM7RST                      \ TIM7 block reset Cleared by software.
$00000200 constant RCC_RCC_APB1RSTCLRR_LPTIM1RST                    \ LPTIM1 block reset Cleared by software.
$00000800 constant RCC_RCC_APB1RSTCLRR_SPI2RST                      \ SPI2 block reset Cleared by software.
$00001000 constant RCC_RCC_APB1RSTCLRR_SPI3RST                      \ SPI3 block reset Cleared by software.
$00008000 constant RCC_RCC_APB1RSTCLRR_USART3RST                    \ USART3 block reset Cleared by software.
$00010000 constant RCC_RCC_APB1RSTCLRR_UART4RST                     \ UART4 block reset Cleared by software.
$00020000 constant RCC_RCC_APB1RSTCLRR_UART5RST                     \ UART5 block reset Cleared by software.
$00040000 constant RCC_RCC_APB1RSTCLRR_UART7RST                     \ UART7 block reset Cleared by software.
$00080000 constant RCC_RCC_APB1RSTCLRR_UART8RST                     \ UART8 block reset Cleared by software.
$00200000 constant RCC_RCC_APB1RSTCLRR_I2C1RST                      \ I2C1 block reset Cleared by software.
$00400000 constant RCC_RCC_APB1RSTCLRR_I2C2RST                      \ I2C2 block reset Cleared by software.
$04000000 constant RCC_RCC_APB1RSTCLRR_SPDIFRST                     \ SPDIFRX block reset Cleared by software.


\
\ @brief This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
\ Address offset: 0x6A8
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB2RSTSETR_TIM1RST                      \ TIM1 block reset Set by software.
$00000002 constant RCC_RCC_APB2RSTSETR_TIM8RST                      \ TIM8 block reset Set by software.
$00000100 constant RCC_RCC_APB2RSTSETR_SPI1RST                      \ SPI/I2S1 block reset Set by software.
$00002000 constant RCC_RCC_APB2RSTSETR_USART6RST                    \ USART6 block reset Set by software.
$00010000 constant RCC_RCC_APB2RSTSETR_SAI1RST                      \ SAI1 block reset Set by software.
$00020000 constant RCC_RCC_APB2RSTSETR_SAI2RST                      \ SAI2 block reset Set by software.
$00100000 constant RCC_RCC_APB2RSTSETR_DFSDMRST                     \ DFSDM block reset Set by software.
$01000000 constant RCC_RCC_APB2RSTSETR_FDCANRST                     \ FDCAN block reset Set by software.


\
\ @brief This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
\ Address offset: 0x6AC
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB2RSTCLRR_TIM1RST                      \ TIM1 block reset Cleared by software.
$00000002 constant RCC_RCC_APB2RSTCLRR_TIM8RST                      \ TIM8 block reset Cleared by software.
$00000100 constant RCC_RCC_APB2RSTCLRR_SPI1RST                      \ SPI/I2S1 block reset Cleared by software.
$00002000 constant RCC_RCC_APB2RSTCLRR_USART6RST                    \ USART6 block reset Cleared by software.
$00010000 constant RCC_RCC_APB2RSTCLRR_SAI1RST                      \ SAI1 block reset Cleared by software.
$00020000 constant RCC_RCC_APB2RSTCLRR_SAI2RST                      \ SAI2 block reset Cleared by software.
$00100000 constant RCC_RCC_APB2RSTCLRR_DFSDMRST                     \ DFSDM block reset Cleared by software.
$01000000 constant RCC_RCC_APB2RSTCLRR_FDCANRST                     \ FDCAN block reset Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
\ Address offset: 0x6B0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB3RSTSETR_LPTIM2RST                    \ LPTIM2 block reset Set by software. If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure.
$00000002 constant RCC_RCC_APB3RSTSETR_LPTIM3RST                    \ LPTIM3 block reset Set by software. If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure.
$00000004 constant RCC_RCC_APB3RSTSETR_LPTIM4RST                    \ LPTIM4 block reset Set by software.
$00000008 constant RCC_RCC_APB3RSTSETR_LPTIM5RST                    \ LPTIM5 block reset Set by software.
$00000800 constant RCC_RCC_APB3RSTSETR_SYSCFGRST                    \ SYSCFG block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00002000 constant RCC_RCC_APB3RSTSETR_VREFRST                      \ VREF block reset If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00010000 constant RCC_RCC_APB3RSTSETR_DTSRST                       \ DTS block reset Set by software.
$00020000 constant RCC_RCC_APB3RSTSETR_PMBCTRLRST                   \ PMBCTRL block reset (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
\ Address offset: 0x6B4
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB3RSTCLRR_LPTIM2RST                    \ LPTIM2 block reset If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000002 constant RCC_RCC_APB3RSTCLRR_LPTIM3RST                    \ LPTIM3 block reset If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000004 constant RCC_RCC_APB3RSTCLRR_LPTIM4RST                    \ LPTIM4 block reset Cleared by software.
$00000008 constant RCC_RCC_APB3RSTCLRR_LPTIM5RST                    \ LPTIM5 block reset Cleared by software.
$00000800 constant RCC_RCC_APB3RSTCLRR_SYSCFGRST                    \ SYSCFG block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00002000 constant RCC_RCC_APB3RSTCLRR_VREFRST                      \ VREF block reset If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00010000 constant RCC_RCC_APB3RSTCLRR_DTSRST                       \ DTS block reset Cleared by software.
$00020000 constant RCC_RCC_APB3RSTCLRR_PMBCTRLRST                   \ PMBCTRL block reset (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
\ Address offset: 0x6B8
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB4RSTSETR_LTDCRST                      \ LTDC block reset If LTDC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000002 constant RCC_RCC_APB4RSTSETR_DCMIPPRST                    \ DCMIPP block reset If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_APB4RSTSETR_DDRPERFMRST                  \ DDRPERFM block reset Set by software.
$00010000 constant RCC_RCC_APB4RSTSETR_USBPHYRST                    \ USBPHYC block reset If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
\ Address offset: 0x6BC
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB4RSTCLRR_LTDCRST                      \ LTDC block reset If LTDC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000002 constant RCC_RCC_APB4RSTCLRR_DCMIPPRST                    \ DCMIPP block reset If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000100 constant RCC_RCC_APB4RSTCLRR_DDRPERFMRST                  \ DDRPERFM block reset Cleared by software.
$00010000 constant RCC_RCC_APB4RSTCLRR_USBPHYRST                    \ USBPHYC block reset If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
\ Address offset: 0x6C0
\ Reset value: 0x00000000
\

$00100000 constant RCC_RCC_APB5RSTSETR_STGENRST                     \ STGEN block reset If STGENC (STGEN controller sub-part) is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
\ Address offset: 0x6C4
\ Reset value: 0x00000000
\

$00100000 constant RCC_RCC_APB5RSTCLRR_STGENRST                     \ STGEN block reset If STGENC (STGEN controller sub-part) is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
\ Address offset: 0x6C8
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB6RSTSETR_USART1RST                    \ USART1 block reset If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000002 constant RCC_RCC_APB6RSTSETR_USART2RST                    \ USART2 block reset If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000004 constant RCC_RCC_APB6RSTSETR_SPI4RST                      \ SPI4 block reset If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000008 constant RCC_RCC_APB6RSTSETR_SPI5RST                      \ SPI5 block reset If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000010 constant RCC_RCC_APB6RSTSETR_I2C3RST                      \ I2C3 block reset If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000020 constant RCC_RCC_APB6RSTSETR_I2C4RST                      \ I2C4 block reset If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000040 constant RCC_RCC_APB6RSTSETR_I2C5RST                      \ I2C5 block reset If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000080 constant RCC_RCC_APB6RSTSETR_TIM12RST                     \ TIM12 block reset If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_APB6RSTSETR_TIM13RST                     \ TIM13 block reset If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000200 constant RCC_RCC_APB6RSTSETR_TIM14RST                     \ TIM14 block reset If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000400 constant RCC_RCC_APB6RSTSETR_TIM15RST                     \ TIM15 block reset If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000800 constant RCC_RCC_APB6RSTSETR_TIM16RST                     \ TIM16 block reset If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00001000 constant RCC_RCC_APB6RSTSETR_TIM17RST                     \ TIM17 block reset If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
\ Address offset: 0x6CC
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB6RSTCLRR_USART1RST                    \ USART1 block reset If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000002 constant RCC_RCC_APB6RSTCLRR_USART2RST                    \ USART2 block reset If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000004 constant RCC_RCC_APB6RSTCLRR_SPI4RST                      \ SPI4 block reset If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000008 constant RCC_RCC_APB6RSTCLRR_SPI5RST                      \ SPI5 block reset If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000010 constant RCC_RCC_APB6RSTCLRR_I2C3RST                      \ I2C3 block reset If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000020 constant RCC_RCC_APB6RSTCLRR_I2C4RST                      \ I2C4 block reset If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000040 constant RCC_RCC_APB6RSTCLRR_I2C5RST                      \ I2C5 block reset If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000080 constant RCC_RCC_APB6RSTCLRR_TIM12RST                     \ TIM12 block reset If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_APB6RSTCLRR_TIM13RST                     \ TIM13 block reset If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000200 constant RCC_RCC_APB6RSTCLRR_TIM14RST                     \ TIM14 block reset If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000400 constant RCC_RCC_APB6RSTCLRR_TIM15RST                     \ TIM15 block reset If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000800 constant RCC_RCC_APB6RSTCLRR_TIM16RST                     \ TIM16 block reset If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00001000 constant RCC_RCC_APB6RSTCLRR_TIM17RST                     \ TIM17 block reset If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
\ Address offset: 0x6D0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB2RSTSETR_DMA1RST                      \ DMA1 block reset Set by software.
$00000002 constant RCC_RCC_AHB2RSTSETR_DMA2RST                      \ DMA2 block reset Set by software.
$00000004 constant RCC_RCC_AHB2RSTSETR_DMAMUX1RST                   \ DMAMUX1 block reset Set by software.
$00000008 constant RCC_RCC_AHB2RSTSETR_DMA3RST                      \ DMA3 block reset If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000010 constant RCC_RCC_AHB2RSTSETR_DMAMUX2RST                   \ DMAMUX2 block reset If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000020 constant RCC_RCC_AHB2RSTSETR_ADC1RST                      \ ADC1 block reset If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000040 constant RCC_RCC_AHB2RSTSETR_ADC2RST                      \ ADC2 block reset If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_AHB2RSTSETR_USBORST                      \ USBO block reset If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
\ Address offset: 0x6D4
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB2RSTCLRR_DMA1RST                      \ DMA1 block reset Cleared by software.
$00000002 constant RCC_RCC_AHB2RSTCLRR_DMA2RST                      \ DMA2 block reset Cleared by software.
$00000004 constant RCC_RCC_AHB2RSTCLRR_DMAMUX1RST                   \ DMAMUX1 block reset Cleared by software.
$00000008 constant RCC_RCC_AHB2RSTCLRR_DMA3RST                      \ DMA3 block reset If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000010 constant RCC_RCC_AHB2RSTCLRR_DMAMUX2RST                   \ DMAMUX2 block reset If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000020 constant RCC_RCC_AHB2RSTCLRR_ADC1RST                      \ ADC1 block reset If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000040 constant RCC_RCC_AHB2RSTCLRR_ADC2RST                      \ ADC2 block reset If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000100 constant RCC_RCC_AHB2RSTCLRR_USBORST                      \ USBO block reset If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
\ Address offset: 0x6E0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB4RSTSETR_GPIOARST                     \ GPIOA block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00000002 constant RCC_RCC_AHB4RSTSETR_GPIOBRST                     \ GPIOB block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00000004 constant RCC_RCC_AHB4RSTSETR_GPIOCRST                     \ GPIOC block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00000008 constant RCC_RCC_AHB4RSTSETR_GPIODRST                     \ GPIOD block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00000010 constant RCC_RCC_AHB4RSTSETR_GPIOERST                     \ GPIOE block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00000020 constant RCC_RCC_AHB4RSTSETR_GPIOFRST                     \ GPIOF block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00000040 constant RCC_RCC_AHB4RSTSETR_GPIOGRST                     \ GPIOG block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00000080 constant RCC_RCC_AHB4RSTSETR_GPIOHRST                     \ GPIOH block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00000100 constant RCC_RCC_AHB4RSTSETR_GPIOIRST                     \ GPIOI block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00008000 constant RCC_RCC_AHB4RSTSETR_TSCRST                       \ TSC block reset If TSC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
\ Address offset: 0x6E4
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB4RSTCLRR_GPIOARST                     \ GPIOA block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00000002 constant RCC_RCC_AHB4RSTCLRR_GPIOBRST                     \ GPIOB block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00000004 constant RCC_RCC_AHB4RSTCLRR_GPIOCRST                     \ GPIOC block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00000008 constant RCC_RCC_AHB4RSTCLRR_GPIODRST                     \ GPIOD block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00000010 constant RCC_RCC_AHB4RSTCLRR_GPIOERST                     \ GPIOE block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00000020 constant RCC_RCC_AHB4RSTCLRR_GPIOFRST                     \ GPIOF block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00000040 constant RCC_RCC_AHB4RSTCLRR_GPIOGRST                     \ GPIOG block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00000080 constant RCC_RCC_AHB4RSTCLRR_GPIOHRST                     \ GPIOH block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00000100 constant RCC_RCC_AHB4RSTCLRR_GPIOIRST                     \ GPIOI block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00008000 constant RCC_RCC_AHB4RSTCLRR_TSCRST                       \ TSC block reset If TSC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
\ Address offset: 0x6E8
\ Reset value: 0x00000000
\

$00000004 constant RCC_RCC_AHB5RSTSETR_PKARST                       \ PKA block reset If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000008 constant RCC_RCC_AHB5RSTSETR_SAESRST                      \ SAES block reset If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000010 constant RCC_RCC_AHB5RSTSETR_CRYP1RST                     \ CRYP (3DES/AES) block reset If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000020 constant RCC_RCC_AHB5RSTSETR_HASH1RST                     \ HASH block reset If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000040 constant RCC_RCC_AHB5RSTSETR_RNG1RST                      \ RNG1 block reset If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00010000 constant RCC_RCC_AHB5RSTSETR_AXIMCRST                     \ AXIMC block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
\ Address offset: 0x6EC
\ Reset value: 0x00000000
\

$00000004 constant RCC_RCC_AHB5RSTCLRR_PKARST                       \ PKA block reset If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000008 constant RCC_RCC_AHB5RSTCLRR_SAESRST                      \ SAES block reset If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000010 constant RCC_RCC_AHB5RSTCLRR_CRYP1RST                     \ CRYP (3DES/AES) block reset If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000020 constant RCC_RCC_AHB5RSTCLRR_HASH1RST                     \ HASH block reset If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000040 constant RCC_RCC_AHB5RSTCLRR_RNG1RST                      \ RNG1 block reset If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00010000 constant RCC_RCC_AHB5RSTCLRR_AXIMCRST                     \ AXIMC block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
\ Address offset: 0x6F0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB6RSTSETR_MDMARST                      \ MDMA block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00000002 constant RCC_RCC_AHB6RSTSETR_MCERST                       \ MCE block reset If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000400 constant RCC_RCC_AHB6RSTSETR_ETH1MACRST                   \ ETH1 MAC block reset If ETH1 MAC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00001000 constant RCC_RCC_AHB6RSTSETR_FMCRST                       \ FMC block reset If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00004000 constant RCC_RCC_AHB6RSTSETR_QSPIRST                      \ QUADSPI and the QUADSPI delay block reset If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00010000 constant RCC_RCC_AHB6RSTSETR_SDMMC1RST                    \ SDMMC1 and the SDMMC1 delay (DLYBSD1) block reset If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00020000 constant RCC_RCC_AHB6RSTSETR_SDMMC2RST                    \ SDMMC2 and the SDMMC2 delay (DLYBSD2) block reset If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00100000 constant RCC_RCC_AHB6RSTSETR_CRC1RST                      \ CRC block reset Set by software.
$01000000 constant RCC_RCC_AHB6RSTSETR_USBHRST                      \ USBH block reset Set by software.
$40000000 constant RCC_RCC_AHB6RSTSETR_ETH2MACRST                   \ ETH2 MAC block reset If ETH2 MAC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
\ Address offset: 0x6F4
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB6RSTCLRR_MDMARST                      \ MDMA block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00000002 constant RCC_RCC_AHB6RSTCLRR_MCERST                       \ MCE block reset If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000400 constant RCC_RCC_AHB6RSTCLRR_ETH1MACRST                   \ ETH1 MAC block reset If ETH1 MAC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00001000 constant RCC_RCC_AHB6RSTCLRR_FMCRST                       \ FMC block reset If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00004000 constant RCC_RCC_AHB6RSTCLRR_QSPIRST                      \ QUADSPI and the QUADSPI delay block reset If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00010000 constant RCC_RCC_AHB6RSTCLRR_SDMMC1RST                    \ SDMMC1 and the SDMMC1 delay (DLYBSD1) block reset If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00020000 constant RCC_RCC_AHB6RSTCLRR_SDMMC2RST                    \ SDMMC2 and the SDMMC2 delay (DLYBSD2) block reset If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00100000 constant RCC_RCC_AHB6RSTCLRR_CRC1RST                      \ CRC block reset Cleared by software.
$01000000 constant RCC_RCC_AHB6RSTCLRR_USBHRST                      \ USBH block reset Cleared by software.
$40000000 constant RCC_RCC_AHB6RSTCLRR_ETH2MACRST                   \ ETH2 MAC block reset If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.


\
\ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective value of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x700
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB1ENSETR_TIM2EN                     \ TIM2 peripheral clocks enable Set by software.
$00000002 constant RCC_RCC_MP_APB1ENSETR_TIM3EN                     \ TIM3 peripheral clocks enable Set by software.
$00000004 constant RCC_RCC_MP_APB1ENSETR_TIM4EN                     \ TIM4 peripheral clocks enable Set by software.
$00000008 constant RCC_RCC_MP_APB1ENSETR_TIM5EN                     \ TIM5 peripheral clocks enable Set by software.
$00000010 constant RCC_RCC_MP_APB1ENSETR_TIM6EN                     \ TIM6 peripheral clocks enable Set by software.
$00000020 constant RCC_RCC_MP_APB1ENSETR_TIM7EN                     \ TIM7 peripheral clocks enable Set by software.
$00000200 constant RCC_RCC_MP_APB1ENSETR_LPTIM1EN                   \ LPTIM1 peripheral clocks enable Set by software.
$00000800 constant RCC_RCC_MP_APB1ENSETR_SPI2EN                     \ SPI2 peripheral clocks enable Set by software.
$00001000 constant RCC_RCC_MP_APB1ENSETR_SPI3EN                     \ SPI3 peripheral clocks enable Set by software.
$00008000 constant RCC_RCC_MP_APB1ENSETR_USART3EN                   \ USART3 peripheral clocks enable Set by software.
$00010000 constant RCC_RCC_MP_APB1ENSETR_UART4EN                    \ UART4 peripheral clocks enable Set by software.
$00020000 constant RCC_RCC_MP_APB1ENSETR_UART5EN                    \ UART5 peripheral clocks enable Set by software.
$00040000 constant RCC_RCC_MP_APB1ENSETR_UART7EN                    \ UART7 peripheral clocks enable Set by software.
$00080000 constant RCC_RCC_MP_APB1ENSETR_UART8EN                    \ UART8 peripheral clocks enable Set by software.
$00200000 constant RCC_RCC_MP_APB1ENSETR_I2C1EN                     \ I2C1 peripheral clocks enable Set by software.
$00400000 constant RCC_RCC_MP_APB1ENSETR_I2C2EN                     \ I2C2 peripheral clocks enable Set by software.
$04000000 constant RCC_RCC_MP_APB1ENSETR_SPDIFEN                    \ SPDIFRX peripheral clocks enable Set by software.


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x704
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB1ENCLRR_TIM2EN                     \ TIM2 peripheral clocks enable Cleared by software.
$00000002 constant RCC_RCC_MP_APB1ENCLRR_TIM3EN                     \ TIM3 peripheral clocks enable Cleared by software.
$00000004 constant RCC_RCC_MP_APB1ENCLRR_TIM4EN                     \ TIM4 peripheral clocks enable Cleared by software.
$00000008 constant RCC_RCC_MP_APB1ENCLRR_TIM5EN                     \ TIM5 peripheral clocks enable Cleared by software.
$00000010 constant RCC_RCC_MP_APB1ENCLRR_TIM6EN                     \ TIM6 peripheral clocks enable Cleared by software.
$00000020 constant RCC_RCC_MP_APB1ENCLRR_TIM7EN                     \ TIM7 peripheral clocks enable Cleared by software.
$00000200 constant RCC_RCC_MP_APB1ENCLRR_LPTIM1EN                   \ LPTIM1 peripheral clocks enable Cleared by software.
$00000800 constant RCC_RCC_MP_APB1ENCLRR_SPI2EN                     \ SPI2 peripheral clocks enable Cleared by software.
$00001000 constant RCC_RCC_MP_APB1ENCLRR_SPI3EN                     \ SPI3 peripheral clocks enable Cleared by software.
$00008000 constant RCC_RCC_MP_APB1ENCLRR_USART3EN                   \ USART3 peripheral clocks enable Cleared by software.
$00010000 constant RCC_RCC_MP_APB1ENCLRR_UART4EN                    \ UART4 peripheral clocks enable Cleared by software.
$00020000 constant RCC_RCC_MP_APB1ENCLRR_UART5EN                    \ UART5 peripheral clocks enable Cleared by software.
$00040000 constant RCC_RCC_MP_APB1ENCLRR_UART7EN                    \ UART7 peripheral clocks enable Cleared by software.
$00080000 constant RCC_RCC_MP_APB1ENCLRR_UART8EN                    \ UART8 peripheral clocks enable Cleared by software.
$00200000 constant RCC_RCC_MP_APB1ENCLRR_I2C1EN                     \ I2C1 peripheral clocks enable Cleared by software.
$00400000 constant RCC_RCC_MP_APB1ENCLRR_I2C2EN                     \ I2C2 peripheral clocks enable Cleared by software.
$04000000 constant RCC_RCC_MP_APB1ENCLRR_SPDIFEN                    \ SPDIFRX peripheral clocks enable Cleared by software.


\
\ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x708
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB2ENSETR_TIM1EN                     \ TIM1 peripheral clocks enable Set by software.
$00000002 constant RCC_RCC_MP_APB2ENSETR_TIM8EN                     \ TIM8 peripheral clocks enable Set by software.
$00000100 constant RCC_RCC_MP_APB2ENSETR_SPI1EN                     \ SPI/I2S1 peripheral clocks enable Set by software.
$00002000 constant RCC_RCC_MP_APB2ENSETR_USART6EN                   \ USART6 peripheral clocks enable Set by software.
$00010000 constant RCC_RCC_MP_APB2ENSETR_SAI1EN                     \ SAI1 peripheral clocks enable Set by software.
$00020000 constant RCC_RCC_MP_APB2ENSETR_SAI2EN                     \ SAI2 peripheral clocks enable Set by software.
$00100000 constant RCC_RCC_MP_APB2ENSETR_DFSDMEN                    \ DFSDM peripheral clocks enable Set by software.
$00200000 constant RCC_RCC_MP_APB2ENSETR_ADFSDMEN                   \ Audio DFSDM peripheral clocks enable Set by software.
$01000000 constant RCC_RCC_MP_APB2ENSETR_FDCANEN                    \ FDCAN and CANRAM peripheral clocks enable Set by software.


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to â0â.
\ Address offset: 0x70C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB2ENCLRR_TIM1EN                     \ TIM1 peripheral clocks enable Cleared by software.
$00000002 constant RCC_RCC_MP_APB2ENCLRR_TIM8EN                     \ TIM8 peripheral clocks enable Cleared by software.
$00000100 constant RCC_RCC_MP_APB2ENCLRR_SPI1EN                     \ SPI/I2S1 peripheral clocks enable Cleared by software.
$00002000 constant RCC_RCC_MP_APB2ENCLRR_USART6EN                   \ USART6 peripheral clocks enable Cleared by software.
$00010000 constant RCC_RCC_MP_APB2ENCLRR_SAI1EN                     \ SAI1 peripheral clocks enable Cleared by software.
$00020000 constant RCC_RCC_MP_APB2ENCLRR_SAI2EN                     \ SAI2 peripheral clocks enable Cleared by software.
$00100000 constant RCC_RCC_MP_APB2ENCLRR_DFSDMEN                    \ DFSDM peripheral clocks enable Cleared by software.
$00200000 constant RCC_RCC_MP_APB2ENCLRR_ADFSDMEN                   \ Audio DFSDM peripheral clocks enable Cleared by software.
$01000000 constant RCC_RCC_MP_APB2ENCLRR_FDCANEN                    \ FDCAN and CANRAM peripheral clocks enable Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x710
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB3ENSETR_LPTIM2EN                   \ LPTIM2 peripheral clocks enable If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000002 constant RCC_RCC_MP_APB3ENSETR_LPTIM3EN                   \ LPTIM3 peripheral clocks enable If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000004 constant RCC_RCC_MP_APB3ENSETR_LPTIM4EN                   \ LPTIM4 peripheral clocks enable Set by software.
$00000008 constant RCC_RCC_MP_APB3ENSETR_LPTIM5EN                   \ LPTIM5 peripheral clocks enable Set by software.
$00002000 constant RCC_RCC_MP_APB3ENSETR_VREFEN                     \ VREF peripheral clocks enable If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00010000 constant RCC_RCC_MP_APB3ENSETR_DTSEN                      \ DTS peripheral clocks enable Set by software.
$00020000 constant RCC_RCC_MP_APB3ENSETR_PMBCTRLEN                  \ PMBCTRL peripheral clocks enable (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT
$00100000 constant RCC_RCC_MP_APB3ENSETR_HDPEN                      \ HDP peripheral clocks enable Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x714
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB3ENCLRR_LPTIM2EN                   \ LPTIM2 peripheral clocks enable If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000002 constant RCC_RCC_MP_APB3ENCLRR_LPTIM3EN                   \ LPTIM3 peripheral clocks enable If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000004 constant RCC_RCC_MP_APB3ENCLRR_LPTIM4EN                   \ LPTIM4 peripheral clocks enable Cleared by software.
$00000008 constant RCC_RCC_MP_APB3ENCLRR_LPTIM5EN                   \ LPTIM5 peripheral clocks enable Cleared by software.
$00002000 constant RCC_RCC_MP_APB3ENCLRR_VREFEN                     \ VREF peripheral clocks enable If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00010000 constant RCC_RCC_MP_APB3ENCLRR_DTSEN                      \ DTS peripheral clocks enable Cleared by software.
$00020000 constant RCC_RCC_MP_APB3ENCLRR_PMBCTRLEN                  \ PMBCTRL peripheral clocks enable (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT
$00100000 constant RCC_RCC_MP_APB3ENCLRR_HDPEN                      \ HDP peripheral clocks enable Cleared by software.


\
\ @brief This is a secure register for enabling the clock of the SYSCFG.
\ Address offset: 0x718
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_S_APB3ENSETR_SYSCFGEN                 \ SYSCFG peripheral clocks enable Set by (secure) software.


\
\ @brief This is a secure register for disabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x71C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_S_APB3ENCLRR_SYSCFGEN                 \ SYSCFG peripheral clocks enable Cleared by (secure) software.


\
\ @brief This is a non-secure register, for enabling the clock of the SYSCFG.
\ Address offset: 0x720
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_NS_APB3ENSETR_SYSCFGEN                \ SYSCFG peripheral clocks enable Set by software.


\
\ @brief This is a non-secure register, for disabling the clock of the SYSCFG.
\ Address offset: 0x724
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_NS_APB3ENCLRR_SYSCFGEN                \ SYSCFG peripheral clocks enable Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x728
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_MP_APB4ENSETR_DCMIPPEN                   \ DCMIPP peripheral clocks enable If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_MP_APB4ENSETR_DDRPERFMEN                 \ DDRPERFM APB clock enable Set by software.
$00008000 constant RCC_RCC_MP_APB4ENSETR_IWDG2APBEN                 \ IWDG2 APB clock enable Set by software.
$00010000 constant RCC_RCC_MP_APB4ENSETR_USBPHYEN                   \ USBPHYC peripheral clocks enable If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00100000 constant RCC_RCC_MP_APB4ENSETR_STGENROEN                  \ STGEN read-only interface peripheral clocks enable Set by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x72C
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_MP_APB4ENCLRR_DCMIPPEN                   \ DCMIPP peripheral clocks enable If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000100 constant RCC_RCC_MP_APB4ENCLRR_DDRPERFMEN                 \ DDRPERFM APB clock enable Cleared by software.
$00008000 constant RCC_RCC_MP_APB4ENCLRR_IWDG2APBEN                 \ IWDG2 APB clock enable Cleared by software.
$00010000 constant RCC_RCC_MP_APB4ENCLRR_USBPHYEN                   \ USBPHYC peripheral clocks enable If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00100000 constant RCC_RCC_MP_APB4ENCLRR_STGENROEN                  \ STGEN read-only interface peripheral clocks enable Cleared by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.


\
\ @brief This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x730
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_S_APB4ENSETR_LTDCEN                   \ LTDC peripheral clocks enable Set by (secure) software.


\
\ @brief This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer.
\ Address offset: 0x734
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_S_APB4ENCLRR_LTDCEN                   \ LTDC peripheral clocks enable Cleared by (secure) software.


\
\ @brief This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x738
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_NS_APB4ENSETR_LTDCEN                  \ LTDC peripheral clocks enable Set by software.


\
\ @brief This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers.
\ Address offset: 0x73C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_NS_APB4ENCLRR_LTDCEN                  \ LTDC peripheral clocks enable Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x740
\ Reset value: 0x00000000
\

$00000100 constant RCC_RCC_MP_APB5ENSETR_RTCAPBEN                   \ RTC APB clock enable If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000800 constant RCC_RCC_MP_APB5ENSETR_TZCEN                      \ TZC clocks enable Set by (secure) software. See for details.
$00002000 constant RCC_RCC_MP_APB5ENSETR_ETZPCEN                    \ ETZPC peripheral clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00008000 constant RCC_RCC_MP_APB5ENSETR_IWDG1APBEN                 \ IWDG1 APB clock enable If IWDG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00010000 constant RCC_RCC_MP_APB5ENSETR_BSECEN                     \ BSEC peripheral clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00100000 constant RCC_RCC_MP_APB5ENSETR_STGENCEN                   \ STGEN controller part, peripheral clocks enable If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x744
\ Reset value: 0x00000000
\

$00000100 constant RCC_RCC_MP_APB5ENCLRR_RTCAPBEN                   \ RTC APB clock enable If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000800 constant RCC_RCC_MP_APB5ENCLRR_TZCEN                      \ TZC clocks enable Cleared by (secure) software. See for details.
$00002000 constant RCC_RCC_MP_APB5ENCLRR_ETZPCEN                    \ ETZPC peripheral clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00008000 constant RCC_RCC_MP_APB5ENCLRR_IWDG1APBEN                 \ IWDG1 APB clock enable If IWDG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00010000 constant RCC_RCC_MP_APB5ENCLRR_BSECEN                     \ BSEC peripheral clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00100000 constant RCC_RCC_MP_APB5ENCLRR_STGENCEN                   \ STGEN controller part, peripheral clocks enable If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x748
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB6ENSETR_USART1EN                   \ USART1 peripherals clocks If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000002 constant RCC_RCC_MP_APB6ENSETR_USART2EN                   \ USART2 peripherals clocks If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000004 constant RCC_RCC_MP_APB6ENSETR_SPI4EN                     \ SPI4 peripherals clocks If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000008 constant RCC_RCC_MP_APB6ENSETR_SPI5EN                     \ SPI5 peripherals clocks If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000010 constant RCC_RCC_MP_APB6ENSETR_I2C3EN                     \ I2C3 peripherals clocks If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000020 constant RCC_RCC_MP_APB6ENSETR_I2C4EN                     \ I2C4 peripherals clocks If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000040 constant RCC_RCC_MP_APB6ENSETR_I2C5EN                     \ I2C5 peripherals clocks If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000080 constant RCC_RCC_MP_APB6ENSETR_TIM12EN                    \ TIM12 peripherals clocks If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_MP_APB6ENSETR_TIM13EN                    \ TIM13 peripherals clocks If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000200 constant RCC_RCC_MP_APB6ENSETR_TIM14EN                    \ TIM14 peripherals clocks If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000400 constant RCC_RCC_MP_APB6ENSETR_TIM15EN                    \ TIM15 peripherals clocks If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000800 constant RCC_RCC_MP_APB6ENSETR_TIM16EN                    \ TIM16 peripherals clocks If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00001000 constant RCC_RCC_MP_APB6ENSETR_TIM17EN                    \ TIM17 peripherals clocks If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x74C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB6ENCLRR_USART1EN                   \ USART1 peripherals clocks If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000002 constant RCC_RCC_MP_APB6ENCLRR_USART2EN                   \ USART2 peripherals clocks If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000004 constant RCC_RCC_MP_APB6ENCLRR_SPI4EN                     \ SPI4 peripherals clocks If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000008 constant RCC_RCC_MP_APB6ENCLRR_SPI5EN                     \ SPI5 peripherals clocks If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000010 constant RCC_RCC_MP_APB6ENCLRR_I2C3EN                     \ I2C3 peripherals clocks If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000020 constant RCC_RCC_MP_APB6ENCLRR_I2C4EN                     \ I2C4 peripherals clocks If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000040 constant RCC_RCC_MP_APB6ENCLRR_I2C5EN                     \ I2C5 peripherals clocks If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000080 constant RCC_RCC_MP_APB6ENCLRR_TIM12EN                    \ TIM12 peripherals clocks If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_MP_APB6ENCLRR_TIM13EN                    \ TIM13 peripherals clocks If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000200 constant RCC_RCC_MP_APB6ENCLRR_TIM14EN                    \ TIM14 peripherals clocks If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000400 constant RCC_RCC_MP_APB6ENCLRR_TIM15EN                    \ TIM15 peripherals clocks If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000800 constant RCC_RCC_MP_APB6ENCLRR_TIM16EN                    \ TIM16 peripherals clocks If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00001000 constant RCC_RCC_MP_APB6ENCLRR_TIM17EN                    \ TIM17 peripherals clocks If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x750
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_AHB2ENSETR_DMA1EN                     \ DMA1 peripheral clocks enable Set by software.
$00000002 constant RCC_RCC_MP_AHB2ENSETR_DMA2EN                     \ DMA2 peripheral clocks enable Set by software.
$00000004 constant RCC_RCC_MP_AHB2ENSETR_DMAMUX1EN                  \ DMAMUX1 peripheral clocks enable Set by software.
$00000008 constant RCC_RCC_MP_AHB2ENSETR_DMA3EN                     \ DMA3 peripheral clocks enable If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000010 constant RCC_RCC_MP_AHB2ENSETR_DMAMUX2EN                  \ DMAMUX2 peripheral clocks enable If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000020 constant RCC_RCC_MP_AHB2ENSETR_ADC1EN                     \ ADC1 peripheral clocks enable If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000040 constant RCC_RCC_MP_AHB2ENSETR_ADC2EN                     \ ADC2 peripheral clocks enable If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_MP_AHB2ENSETR_USBOEN                     \ USBO peripheral clocks enable If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x754
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_AHB2ENCLRR_DMA1EN                     \ DMA1 peripheral clocks enable Cleared by software.
$00000002 constant RCC_RCC_MP_AHB2ENCLRR_DMA2EN                     \ DMA2 peripheral clocks enable Cleared by software.
$00000004 constant RCC_RCC_MP_AHB2ENCLRR_DMAMUX1EN                  \ DMAMUX1 peripheral clocks enable Cleared by software.
$00000008 constant RCC_RCC_MP_AHB2ENCLRR_DMA3EN                     \ DMA3 peripheral clocks enable If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000010 constant RCC_RCC_MP_AHB2ENCLRR_DMAMUX2EN                  \ DMAMUX2 peripheral clocks enable If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000020 constant RCC_RCC_MP_AHB2ENCLRR_ADC1EN                     \ ADC1 peripheral clocks enable If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000040 constant RCC_RCC_MP_AHB2ENCLRR_ADC2EN                     \ ADC2 peripheral clocks enable If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000100 constant RCC_RCC_MP_AHB2ENCLRR_USBOEN                     \ USBO peripheral clocks enable If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.


\
\ @brief This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x760
\ Reset value: 0x00000000
\

$00008000 constant RCC_RCC_MP_AHB4ENSETR_TSCEN                      \ TSC peripheral clocks enable Set by software.


\
\ @brief This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x764
\ Reset value: 0x00000000
\

$00008000 constant RCC_RCC_MP_AHB4ENCLRR_TSCEN                      \ TSC peripheral clocks enable Cleared by software.


\
\ @brief This is a secure register, for enabling the clock of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x768
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_S_AHB4ENSETR_GPIOAEN                  \ GPIOA peripheral clocks enable Set by (secure) software.
$00000002 constant RCC_RCC_MP_S_AHB4ENSETR_GPIOBEN                  \ GPIOB peripheral clocks enable Set by (secure) software.
$00000004 constant RCC_RCC_MP_S_AHB4ENSETR_GPIOCEN                  \ GPIOC peripheral clocks enable Set by (secure) software.
$00000008 constant RCC_RCC_MP_S_AHB4ENSETR_GPIODEN                  \ GPIOD peripheral clocks enable Set by (secure) software.
$00000010 constant RCC_RCC_MP_S_AHB4ENSETR_GPIOEEN                  \ GPIOE peripheral clocks enable Set by (secure) software.
$00000020 constant RCC_RCC_MP_S_AHB4ENSETR_GPIOFEN                  \ GPIOF peripheral clocks enable Set by (secure) software.
$00000040 constant RCC_RCC_MP_S_AHB4ENSETR_GPIOGEN                  \ GPIOG peripheral clocks enable Set by (secure) software.
$00000080 constant RCC_RCC_MP_S_AHB4ENSETR_GPIOHEN                  \ GPIOH peripheral clocks enable Set by (secure) software.
$00000100 constant RCC_RCC_MP_S_AHB4ENSETR_GPIOIEN                  \ GPIOI peripheral clocks enable Set by (secure) software.


\
\ @brief This is a secure register, for disabling of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x76C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_S_AHB4ENCLRR_GPIOAEN                  \ GPIOA peripheral clocks enable Cleared by (secure) software.
$00000002 constant RCC_RCC_MP_S_AHB4ENCLRR_GPIOBEN                  \ GPIOB peripheral clocks enable Cleared by (secure) software.
$00000004 constant RCC_RCC_MP_S_AHB4ENCLRR_GPIOCEN                  \ GPIOC peripheral clocks enable Cleared by (secure) software.
$00000008 constant RCC_RCC_MP_S_AHB4ENCLRR_GPIODEN                  \ GPIOD peripheral clocks enable Cleared by (secure) software.
$00000010 constant RCC_RCC_MP_S_AHB4ENCLRR_GPIOEEN                  \ GPIOE peripheral clocks enable Cleared by (secure) software.
$00000020 constant RCC_RCC_MP_S_AHB4ENCLRR_GPIOFEN                  \ GPIOF peripheral clocks enable Cleared by (secure) software.
$00000040 constant RCC_RCC_MP_S_AHB4ENCLRR_GPIOGEN                  \ GPIOG peripheral clocks enable Cleared by (secure) software.
$00000080 constant RCC_RCC_MP_S_AHB4ENCLRR_GPIOHEN                  \ GPIOH peripheral clocks enable Cleared by (secure) software.
$00000100 constant RCC_RCC_MP_S_AHB4ENCLRR_GPIOIEN                  \ GPIOI peripheral clocks enable Cleared by (secure) software.


\
\ @brief This is a non-secure register, for enabling the non-secure GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x770
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_NS_AHB4ENSETR_GPIOAEN                 \ GPIOA peripheral clocks enable Set by software.
$00000002 constant RCC_RCC_MP_NS_AHB4ENSETR_GPIOBEN                 \ GPIOB peripheral clocks enable Set by software.
$00000004 constant RCC_RCC_MP_NS_AHB4ENSETR_GPIOCEN                 \ GPIOC peripheral clocks enable Set by software.
$00000008 constant RCC_RCC_MP_NS_AHB4ENSETR_GPIODEN                 \ GPIOD peripheral clocks enable Set by software.
$00000010 constant RCC_RCC_MP_NS_AHB4ENSETR_GPIOEEN                 \ GPIOE peripheral clocks enable Set by software.
$00000020 constant RCC_RCC_MP_NS_AHB4ENSETR_GPIOFEN                 \ GPIOF peripheral clocks enable Set by software.
$00000040 constant RCC_RCC_MP_NS_AHB4ENSETR_GPIOGEN                 \ GPIOG peripheral clocks enable Set by software.
$00000080 constant RCC_RCC_MP_NS_AHB4ENSETR_GPIOHEN                 \ GPIOH peripheral clocks enable Set by software.
$00000100 constant RCC_RCC_MP_NS_AHB4ENSETR_GPIOIEN                 \ GPIOI peripheral clocks enable Set by software.


\
\ @brief This is a non-secure register, for disabling the non-secure GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x774
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_NS_AHB4ENCLRR_GPIOAEN                 \ GPIOA peripheral clocks enable Cleared by software.
$00000002 constant RCC_RCC_MP_NS_AHB4ENCLRR_GPIOBEN                 \ GPIOB peripheral clocks enable Cleared by software.
$00000004 constant RCC_RCC_MP_NS_AHB4ENCLRR_GPIOCEN                 \ GPIOC peripheral clocks enable Cleared by software.
$00000008 constant RCC_RCC_MP_NS_AHB4ENCLRR_GPIODEN                 \ GPIOD peripheral clocks enable Cleared by software.
$00000010 constant RCC_RCC_MP_NS_AHB4ENCLRR_GPIOEEN                 \ GPIOE peripheral clocks enable Cleared by software.
$00000020 constant RCC_RCC_MP_NS_AHB4ENCLRR_GPIOFEN                 \ GPIOF peripheral clocks enable Cleared by software.
$00000040 constant RCC_RCC_MP_NS_AHB4ENCLRR_GPIOGEN                 \ GPIOG peripheral clocks enable Cleared by software.
$00000080 constant RCC_RCC_MP_NS_AHB4ENCLRR_GPIOHEN                 \ GPIOH peripheral clocks enable Cleared by software.
$00000100 constant RCC_RCC_MP_NS_AHB4ENCLRR_GPIOIEN                 \ GPIOI peripheral clocks enable Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral to the MPU. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x778
\ Reset value: 0x00010000
\

$00000004 constant RCC_RCC_MP_AHB5ENSETR_PKAEN                      \ PKA peripheral clocks enable If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000008 constant RCC_RCC_MP_AHB5ENSETR_SAESEN                     \ SAES peripheral clocks enable If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000010 constant RCC_RCC_MP_AHB5ENSETR_CRYP1EN                    \ CRYP (3DES/AES) peripheral clocks enable If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000020 constant RCC_RCC_MP_AHB5ENSETR_HASH1EN                    \ HASH peripheral clocks enable If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000040 constant RCC_RCC_MP_AHB5ENSETR_RNG1EN                     \ RNG1 peripheral clocks enable If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_MP_AHB5ENSETR_BKPSRAMEN                  \ BKPSRAM clocks enable If BKPSRAM is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00010000 constant RCC_RCC_MP_AHB5ENSETR_AXIMCEN                    \ AXIMC clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x77C
\ Reset value: 0x00010000
\

$00000004 constant RCC_RCC_MP_AHB5ENCLRR_PKAEN                      \ PKA peripheral clocks enable If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000008 constant RCC_RCC_MP_AHB5ENCLRR_SAESEN                     \ SAES peripheral clocks enable If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000010 constant RCC_RCC_MP_AHB5ENCLRR_CRYP1EN                    \ CRYP (3DES/AES) peripheral clocks enable If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000020 constant RCC_RCC_MP_AHB5ENCLRR_HASH1EN                    \ HASH peripheral clocks enable If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000040 constant RCC_RCC_MP_AHB5ENCLRR_RNG1EN                     \ RNG1 peripheral clocks enable If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000100 constant RCC_RCC_MP_AHB5ENCLRR_BKPSRAMEN                  \ BKPSRAM clocks enable If BKPSRAM is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00010000 constant RCC_RCC_MP_AHB5ENCLRR_AXIMCEN                    \ AXIMC clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x780
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_MP_AHB6ENSETR_MCEEN                      \ MCE peripheral clocks enable If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000080 constant RCC_RCC_MP_AHB6ENSETR_ETH1CKEN                   \ Enable of the ETH1 clock generated by the RCC (eth1_ker_ck) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_MP_AHB6ENSETR_ETH1TXEN                   \ ETH1 transmission clock enable If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000200 constant RCC_RCC_MP_AHB6ENSETR_ETH1RXEN                   \ ETH1 reception clock enable If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000400 constant RCC_RCC_MP_AHB6ENSETR_ETH1MACEN                  \ ETH1 MAC bus interface clock enable (hclk6 and aclk) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00001000 constant RCC_RCC_MP_AHB6ENSETR_FMCEN                      \ FMC peripheral clocks enable If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00004000 constant RCC_RCC_MP_AHB6ENSETR_QSPIEN                     \ QUADSPI peripheral clocks enable If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00010000 constant RCC_RCC_MP_AHB6ENSETR_SDMMC1EN                   \ SDMMC1 and SDMMC1 delay (DLYBSD1) block peripheral clocks enable If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00020000 constant RCC_RCC_MP_AHB6ENSETR_SDMMC2EN                   \ SDMMC2 and SDMMC2 delay (DLYBSD2) block peripheral clocks enable If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00100000 constant RCC_RCC_MP_AHB6ENSETR_CRC1EN                     \ CRC peripheral clocks enable Set by software.
$01000000 constant RCC_RCC_MP_AHB6ENSETR_USBHEN                     \ USBH peripheral clocks enable Set by software.
$08000000 constant RCC_RCC_MP_AHB6ENSETR_ETH2CKEN                   \ Enable of the ETH2 clock generated by the RCC (eth2_ker_ck) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$10000000 constant RCC_RCC_MP_AHB6ENSETR_ETH2TXEN                   \ ETH2 transmission clock enable If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$20000000 constant RCC_RCC_MP_AHB6ENSETR_ETH2RXEN                   \ ETH2 reception clock enable If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$40000000 constant RCC_RCC_MP_AHB6ENSETR_ETH2MACEN                  \ ETH2 MAC bus interface clock enable (hclk6 and aclk) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x784
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_MP_AHB6ENCLRR_MCEEN                      \ MCE peripheral clocks enable If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000080 constant RCC_RCC_MP_AHB6ENCLRR_ETH1CKEN                   \ Enable of the ETH1 clock generated by the RCC (eth1_ker_ck) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000100 constant RCC_RCC_MP_AHB6ENCLRR_ETH1TXEN                   \ ETH1 transmission clock enable If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000200 constant RCC_RCC_MP_AHB6ENCLRR_ETH1RXEN                   \ ETH1 reception clock enable If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000400 constant RCC_RCC_MP_AHB6ENCLRR_ETH1MACEN                  \ ETH1 MAC bus interface clock enable (hclk6 and aclk) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00001000 constant RCC_RCC_MP_AHB6ENCLRR_FMCEN                      \ FMC peripheral clocks enable If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00004000 constant RCC_RCC_MP_AHB6ENCLRR_QSPIEN                     \ QUADSPI peripheral clocks enable If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00010000 constant RCC_RCC_MP_AHB6ENCLRR_SDMMC1EN                   \ SDMMC1 and SDMMC1 delay (DLYBSD1) block peripheral clocks enable If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00020000 constant RCC_RCC_MP_AHB6ENCLRR_SDMMC2EN                   \ SDMMC2 and SDMMC2 delay (DLYBSD2) block peripheral clocks enable If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00100000 constant RCC_RCC_MP_AHB6ENCLRR_CRC1EN                     \ CRC peripheral clocks enable Cleared by software.
$01000000 constant RCC_RCC_MP_AHB6ENCLRR_USBHEN                     \ USBH peripheral clocks enable Cleared by software.
$08000000 constant RCC_RCC_MP_AHB6ENCLRR_ETH2CKEN                   \ Enable of the ETH2 clock generated by the RCC (eth2_ker_ck) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$10000000 constant RCC_RCC_MP_AHB6ENCLRR_ETH2TXEN                   \ ETH2 transmission clock enable If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$20000000 constant RCC_RCC_MP_AHB6ENCLRR_ETH2RXEN                   \ ETH2 reception clock enable If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$40000000 constant RCC_RCC_MP_AHB6ENCLRR_ETH2MACEN                  \ ETH2 MAC bus interface clock enable (hclk6 and aclk) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.


\
\ @brief This is a secure register for enabling the clock of the MDMA when it is used as secure. A write access to this register field must be secure. A read access may be secure or non- secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x788
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_S_AHB6ENSETR_MDMAEN                   \ MDMA peripheral clocks enable Set by (secure) software.


\
\ @brief This is a secure register for disabling the clock of the MDMA when it is not used as secure. A write access to this register field must be secure. A read access may be secure or non- secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x78C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_S_AHB6ENCLRR_MDMAEN                   \ MDMA peripheral clocks enable Cleared by (secure) software.


\
\ @brief This is a non-secure register for enabling the clock of the MDMA when it is used as non- secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x790
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_NS_AHB6ENSETR_MDMAEN                  \ MDMA peripheral clocks enable Set by software.


\
\ @brief This is a non-secure register for disabling the clock of the MDMA when it is not used as non- secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x794
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_NS_AHB6ENCLRR_MDMAEN                  \ MDMA peripheral clocks enable Set by software.


\
\ @brief This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x800
\ Reset value: 0x046F9A3F
\

$00000001 constant RCC_RCC_MP_APB1LPENSETR_TIM2LPEN                 \ TIM2 peripheral clocks enable during CSleep mode Set by software.
$00000002 constant RCC_RCC_MP_APB1LPENSETR_TIM3LPEN                 \ TIM3 peripheral clocks enable during CSleep mode Set by software.
$00000004 constant RCC_RCC_MP_APB1LPENSETR_TIM4LPEN                 \ TIM4 peripheral clocks enable during CSleep mode Set by software.
$00000008 constant RCC_RCC_MP_APB1LPENSETR_TIM5LPEN                 \ TIM5 peripheral clocks enable during CSleep mode Set by software.
$00000010 constant RCC_RCC_MP_APB1LPENSETR_TIM6LPEN                 \ TIM6 peripheral clocks enable during CSleep mode Set by software.
$00000020 constant RCC_RCC_MP_APB1LPENSETR_TIM7LPEN                 \ TIM7 peripheral clocks enable during CSleep mode Set by software.
$00000200 constant RCC_RCC_MP_APB1LPENSETR_LPTIM1LPEN               \ LPTIM1 peripheral clocks enable during CSleep mode Set by software.
$00000800 constant RCC_RCC_MP_APB1LPENSETR_SPI2LPEN                 \ SPI2 peripheral clocks enable during CSleep mode Set by software.
$00001000 constant RCC_RCC_MP_APB1LPENSETR_SPI3LPEN                 \ SPI3 peripheral clocks enable during CSleep mode Set by software.
$00008000 constant RCC_RCC_MP_APB1LPENSETR_USART3LPEN               \ USART3 peripheral clocks enable during CSleep mode Set by software.
$00010000 constant RCC_RCC_MP_APB1LPENSETR_UART4LPEN                \ UART4 peripheral clocks enable during CSleep mode Set by software.
$00020000 constant RCC_RCC_MP_APB1LPENSETR_UART5LPEN                \ UART5 peripheral clocks enable during CSleep mode Set by software.
$00040000 constant RCC_RCC_MP_APB1LPENSETR_UART7LPEN                \ UART7 peripheral clocks enable during CSleep mode Set by software.
$00080000 constant RCC_RCC_MP_APB1LPENSETR_UART8LPEN                \ UART8 peripheral clocks enable during CSleep mode Set by software.
$00200000 constant RCC_RCC_MP_APB1LPENSETR_I2C1LPEN                 \ I2C1 peripheral clocks enable during CSleep mode Set by software.
$00400000 constant RCC_RCC_MP_APB1LPENSETR_I2C2LPEN                 \ I2C2 peripheral clocks enable during CSleep mode Set by software.
$04000000 constant RCC_RCC_MP_APB1LPENSETR_SPDIFLPEN                \ SPDIFRX peripheral clocks enable during CSleep mode Set by software.


\
\ @brief This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x804
\ Reset value: 0x046F9A3F
\

$00000001 constant RCC_RCC_MP_APB1LPENCLRR_TIM2LPEN                 \ TIM2 peripheral clocks enable during CSleep mode Cleared by software.
$00000002 constant RCC_RCC_MP_APB1LPENCLRR_TIM3LPEN                 \ TIM3 peripheral clocks enable during CSleep mode Cleared by software.
$00000004 constant RCC_RCC_MP_APB1LPENCLRR_TIM4LPEN                 \ TIM4 peripheral clocks enable during CSleep mode Cleared by software.
$00000008 constant RCC_RCC_MP_APB1LPENCLRR_TIM5LPEN                 \ TIM5 peripheral clocks enable during CSleep mode Cleared by software.
$00000010 constant RCC_RCC_MP_APB1LPENCLRR_TIM6LPEN                 \ TIM6 peripheral clocks enable during CSleep mode Cleared by software.
$00000020 constant RCC_RCC_MP_APB1LPENCLRR_TIM7LPEN                 \ TIM7 peripheral clocks enable during CSleep mode Cleared by software.
$00000200 constant RCC_RCC_MP_APB1LPENCLRR_LPTIM1LPEN               \ LPTIM1 peripheral clocks enable during CSleep mode Cleared by software.
$00000800 constant RCC_RCC_MP_APB1LPENCLRR_SPI2LPEN                 \ SPI2 peripheral clocks enable during CSleep mode Cleared by software.
$00001000 constant RCC_RCC_MP_APB1LPENCLRR_SPI3LPEN                 \ SPI3 peripheral clocks enable during CSleep mode Cleared by software.
$00008000 constant RCC_RCC_MP_APB1LPENCLRR_USART3LPEN               \ USART3 peripheral clocks enable during CSleep mode Cleared by software.
$00010000 constant RCC_RCC_MP_APB1LPENCLRR_UART4LPEN                \ UART4 peripheral clocks enable during CSleep mode Cleared by software.
$00020000 constant RCC_RCC_MP_APB1LPENCLRR_UART5LPEN                \ UART5 peripheral clocks enable during CSleep mode Cleared by software.
$00040000 constant RCC_RCC_MP_APB1LPENCLRR_UART7LPEN                \ UART7 peripheral clocks enable during CSleep mode Cleared by software.
$00080000 constant RCC_RCC_MP_APB1LPENCLRR_UART8LPEN                \ UART8 peripheral clocks enable during CSleep mode Cleared by software.
$00200000 constant RCC_RCC_MP_APB1LPENCLRR_I2C1LPEN                 \ I2C1 peripheral clocks enable during CSleep mode Cleared by software.
$00400000 constant RCC_RCC_MP_APB1LPENCLRR_I2C2LPEN                 \ I2C2 peripheral clocks enable during CSleep mode Cleared by software.
$04000000 constant RCC_RCC_MP_APB1LPENCLRR_SPDIFLPEN                \ SPDIFRX peripheral clocks enable during CSleep mode Cleared by software.


\
\ @brief This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x808
\ Reset value: 0x01332103
\

$00000001 constant RCC_RCC_MP_APB2LPENSETR_TIM1LPEN                 \ TIM1 peripheral clocks enable during CSleep mode Set by software.
$00000002 constant RCC_RCC_MP_APB2LPENSETR_TIM8LPEN                 \ TIM8 peripheral clocks enable during CSleep mode Set by software.
$00000100 constant RCC_RCC_MP_APB2LPENSETR_SPI1LPEN                 \ SPI/I2S1 peripheral clocks enable during CSleep mode Set by software.
$00002000 constant RCC_RCC_MP_APB2LPENSETR_USART6LPEN               \ USART6 peripheral clocks enable during CSleep mode Set by software.
$00010000 constant RCC_RCC_MP_APB2LPENSETR_SAI1LPEN                 \ SAI1 peripheral clocks enable during CSleep mode Set by software.
$00020000 constant RCC_RCC_MP_APB2LPENSETR_SAI2LPEN                 \ SAI2 peripheral clocks enable during CSleep mode Set by software.
$00100000 constant RCC_RCC_MP_APB2LPENSETR_DFSDMLPEN                \ DFSDM peripheral clocks enable during CSleep mode Set by software.
$00200000 constant RCC_RCC_MP_APB2LPENSETR_ADFSDMLPEN               \ Audio DFSDM peripheral clocks enable during CSleep mode Set by software.
$01000000 constant RCC_RCC_MP_APB2LPENSETR_FDCANLPEN                \ FDCAN and CANRAM peripheral clocks enable during CSleep mode Set by software.


\
\ @brief This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x80C
\ Reset value: 0x01332103
\

$00000001 constant RCC_RCC_MP_APB2LPENCLRR_TIM1LPEN                 \ TIM1 peripheral clocks enable during CSleep mode Cleared by software.
$00000002 constant RCC_RCC_MP_APB2LPENCLRR_TIM8LPEN                 \ TIM8 peripheral clocks enable during CSleep mode Cleared by software.
$00000100 constant RCC_RCC_MP_APB2LPENCLRR_SPI1LPEN                 \ SPI/I2S1 peripheral clocks enable during CSleep mode Cleared by software.
$00002000 constant RCC_RCC_MP_APB2LPENCLRR_USART6LPEN               \ USART6 peripheral clocks enable during CSleep mode Cleared by software.
$00010000 constant RCC_RCC_MP_APB2LPENCLRR_SAI1LPEN                 \ SAI1 peripheral clocks enable during CSleep mode Cleared by software.
$00020000 constant RCC_RCC_MP_APB2LPENCLRR_SAI2LPEN                 \ SAI2 peripheral clocks enable during CSleep mode Cleared by software.
$00100000 constant RCC_RCC_MP_APB2LPENCLRR_DFSDMLPEN                \ DFSDM peripheral clocks enable during CSleep mode Cleared by software.
$00200000 constant RCC_RCC_MP_APB2LPENCLRR_ADFSDMLPEN               \ Audio DFSDM peripheral clocks enable during CSleep mode Cleared by software.
$01000000 constant RCC_RCC_MP_APB2LPENCLRR_FDCANLPEN                \ FDCAN and CANRAM peripheral clocks enable during CSleep mode Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x810
\ Reset value: 0x0003200F
\

$00000001 constant RCC_RCC_MP_APB3LPENSETR_LPTIM2LPEN               \ LPTIM2 peripheral clocks enable during CSleep mode If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000002 constant RCC_RCC_MP_APB3LPENSETR_LPTIM3LPEN               \ LPTIM3 peripheral clocks enable during CSleep mode If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000004 constant RCC_RCC_MP_APB3LPENSETR_LPTIM4LPEN               \ LPTIM4 peripheral clocks enable during CSleep mode Set by software.
$00000008 constant RCC_RCC_MP_APB3LPENSETR_LPTIM5LPEN               \ LPTIM5 peripheral clocks enable during CSleep mode Set by software.
$00002000 constant RCC_RCC_MP_APB3LPENSETR_VREFLPEN                 \ VREF peripheral clocks enable during CSleep mode If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00010000 constant RCC_RCC_MP_APB3LPENSETR_DTSLPEN                  \ DTS peripheral clocks enable during CSleep mode Set by software.
$00020000 constant RCC_RCC_MP_APB3LPENSETR_PMBCTRLLPEN              \ PMBCTRL peripheral clocks enable during CSeep mode (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x814
\ Reset value: 0x0003200F
\

$00000001 constant RCC_RCC_MP_APB3LPENCLRR_LPTIM2LPEN               \ LPTIM2 peripheral clocks enable during CSleep mode If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000002 constant RCC_RCC_MP_APB3LPENCLRR_LPTIM3LPEN               \ LPTIM3 peripheral clocks enable during CSleep mode If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000004 constant RCC_RCC_MP_APB3LPENCLRR_LPTIM4LPEN               \ LPTIM4 peripheral clocks enable during CSleep mode Cleared by software.
$00000008 constant RCC_RCC_MP_APB3LPENCLRR_LPTIM5LPEN               \ LPTIM5 peripheral clocks enable during CSleep mode Cleared by software.
$00002000 constant RCC_RCC_MP_APB3LPENCLRR_VREFLPEN                 \ VREF peripheral clocks enable during CSleep mode If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00010000 constant RCC_RCC_MP_APB3LPENCLRR_DTSLPEN                  \ DTS peripheral clocks enable during CSleep mode Cleared by software.
$00020000 constant RCC_RCC_MP_APB3LPENCLRR_PMBCTRLLPEN              \ PMBCTRL peripheral clocks enable during CSeep mode (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT


\
\ @brief This is a secure register for enabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x818
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_S_APB3LPENSETR_SYSCFGLPEN             \ SYSCFG peripheral clocks enable during CSleep mode Set by (secure) software.


\
\ @brief This is a secure register for disabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x81C
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_S_APB3LPENCLRR_SYSCFGLPEN             \ SYSCFG peripheral clocks enable during CSleep mode Cleared by (secure) software.


\
\ @brief This is a non-secure register, for enabling the clock of the SYSCFG. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x820
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_NS_APB3LPENSETR_SYSCFGLPEN            \ SYSCFG peripheral clocks enable during CSleep mode Set by software.


\
\ @brief This is a non-secure register, for disabling the clock of the SYSCFG. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x824
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_NS_APB3LPENCLRR_SYSCFGLPEN            \ SYSCFG peripheral clocks enable during CSleep mode Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x828
\ Reset value: 0x00118102
\

$00000002 constant RCC_RCC_MP_APB4LPENSETR_DCMIPPLPEN               \ DCMIPP peripheral clocks enable during CSleep mode If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_MP_APB4LPENSETR_DDRPERFMLPEN             \ DDRPERFM APB clock enable during CSleep mode Set by software.
$00008000 constant RCC_RCC_MP_APB4LPENSETR_IWDG2APBLPEN             \ IWDG2 APB clock enable during CSleep mode Set by software.
$00010000 constant RCC_RCC_MP_APB4LPENSETR_USBPHYLPEN               \ USBPHYC peripheral clocks enable during CSleep mode If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00100000 constant RCC_RCC_MP_APB4LPENSETR_STGENROLPEN              \ STGEN read-only interface peripheral clocks enable during CSleep mode Set by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.
$00200000 constant RCC_RCC_MP_APB4LPENSETR_STGENROSTPEN             \ STGEN read-only interface peripheral clocks enable during CStop mode Set by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x82C
\ Reset value: 0x00118102
\

$00000002 constant RCC_RCC_MP_APB4LPENCLRR_DCMIPPLPEN               \ DCMIPP peripheral clocks enable during CSleep mode If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000100 constant RCC_RCC_MP_APB4LPENCLRR_DDRPERFMLPEN             \ DDRPERFM APB clock enable during CSleep mode Cleared by software.
$00008000 constant RCC_RCC_MP_APB4LPENCLRR_IWDG2APBLPEN             \ IWDG2 APB clock enable during CSleep mode Cleared by software.
$00010000 constant RCC_RCC_MP_APB4LPENCLRR_USBPHYLPEN               \ USBPHYC peripheral clocks enable during CSleep mode If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00100000 constant RCC_RCC_MP_APB4LPENCLRR_STGENROLPEN              \ STGEN read-only interface peripheral clocks enable during CSleep mode Cleared by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.
$00200000 constant RCC_RCC_MP_APB4LPENCLRR_STGENROSTPEN             \ STGEN read-only interface peripheral clocks enable during CStop mode Cleared by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.


\
\ @brief This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x830
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_S_APB4LPENSETR_LTDCLPEN               \ LTDC peripheral clocks enable during CSleep mode Set by (secure) software.


\
\ @brief This is a secure register for disabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x834
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_S_APB4LPENCLRR_LTDCLPEN               \ LTDC peripheral clocks enable during CSleep mode Cleared by (secure) software.


\
\ @brief This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x838
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_NS_APB4LPENSETR_LTDCLPEN              \ LTDC peripheral clocks enable during CSleep mode Set by software.


\
\ @brief This is a non-secure register, for disabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x83C
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_NS_APB4LPENCLRR_LTDCLPEN              \ LTDC peripheral clocks enable during CSleep mode Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x840
\ Reset value: 0x0011A900
\

$00000100 constant RCC_RCC_MP_APB5LPENSETR_RTCAPBLPEN               \ RTC APB clock enable during CSleep mode If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000800 constant RCC_RCC_MP_APB5LPENSETR_TZCLPEN                  \ TZC clocks enable during CSleep mode Set by (secure) software. See for details.
$00002000 constant RCC_RCC_MP_APB5LPENSETR_ETZPCLPEN                \ ETZPC peripheral clocks enable during CSleep mode A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00008000 constant RCC_RCC_MP_APB5LPENSETR_IWDG1APBLPEN             \ IWDG1 APB clock enable during CSleep mode If IWDG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00010000 constant RCC_RCC_MP_APB5LPENSETR_BSECLPEN                 \ BSEC peripheral clocks enable during CSleep mode A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
$00100000 constant RCC_RCC_MP_APB5LPENSETR_STGENCLPEN               \ STGEN controller part, peripheral clocks enable during CSleep mode If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.
$00200000 constant RCC_RCC_MP_APB5LPENSETR_STGENCSTPEN              \ STGEN controller part, peripheral clocks enable during CStop mode If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x844
\ Reset value: 0x0011A900
\

$00000100 constant RCC_RCC_MP_APB5LPENCLRR_RTCAPBLPEN               \ RTC APB clock enable during CSleep mode If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000800 constant RCC_RCC_MP_APB5LPENCLRR_TZCLPEN                  \ TZC clocks enable during CSleep mode Cleared by (secure) software. See for details.
$00002000 constant RCC_RCC_MP_APB5LPENCLRR_ETZPCLPEN                \ ETZPC peripheral clocks enable during CSleep mode A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00008000 constant RCC_RCC_MP_APB5LPENCLRR_IWDG1APBLPEN             \ IWDG1 APB clock enable during CSleep mode If IWDG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00010000 constant RCC_RCC_MP_APB5LPENCLRR_BSECLPEN                 \ BSEC peripheral clocks enable during CSleep mode A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
$00100000 constant RCC_RCC_MP_APB5LPENCLRR_STGENCLPEN               \ STGEN controller part, peripheral clocks enable during CSleep mode If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.
$00200000 constant RCC_RCC_MP_APB5LPENCLRR_STGENCSTPEN              \ STGEN controller part, peripheral clocks enable during CStop mode If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x848
\ Reset value: 0x00001FFF
\

$00000001 constant RCC_RCC_MP_APB6LPENSETR_USART1LPEN               \ USART1 peripherals clocks during CSleep mode If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000002 constant RCC_RCC_MP_APB6LPENSETR_USART2LPEN               \ USART2 peripherals clocks during CSleep mode If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000004 constant RCC_RCC_MP_APB6LPENSETR_SPI4LPEN                 \ SPI4 peripherals clocks during CSleep mode If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000008 constant RCC_RCC_MP_APB6LPENSETR_SPI5LPEN                 \ SPI5 peripherals clocks during CSleep mode If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000010 constant RCC_RCC_MP_APB6LPENSETR_I2C3LPEN                 \ I2C3 peripherals clocks during CSleep mode If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000020 constant RCC_RCC_MP_APB6LPENSETR_I2C4LPEN                 \ I2C4 peripherals clocks during CSleep mode If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000040 constant RCC_RCC_MP_APB6LPENSETR_I2C5LPEN                 \ I2C5 peripherals clocks during CSleep mode If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000080 constant RCC_RCC_MP_APB6LPENSETR_TIM12LPEN                \ TIM12 peripherals clocks during CSleep mode If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000100 constant RCC_RCC_MP_APB6LPENSETR_TIM13LPEN                \ TIM13 peripherals clocks during CSleep mode If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000200 constant RCC_RCC_MP_APB6LPENSETR_TIM14LPEN                \ TIM14 peripherals clocks during CSleep mode If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000400 constant RCC_RCC_MP_APB6LPENSETR_TIM15LPEN                \ TIM15 peripherals clocks during CSleep mode If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000800 constant RCC_RCC_MP_APB6LPENSETR_TIM16LPEN                \ TIM16 peripherals clocks during CSleep mode If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00001000 constant RCC_RCC_MP_APB6LPENSETR_TIM17LPEN                \ TIM17 peripherals clocks during CSleep mode If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x84C
\ Reset value: 0x00001FFF
\

$00000001 constant RCC_RCC_MP_APB6LPENCLRR_USART1LPEN               \ USART1 peripherals clocks during CSleep mode If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000002 constant RCC_RCC_MP_APB6LPENCLRR_USART2LPEN               \ USART2 peripherals clocks during CSleep mode If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000004 constant RCC_RCC_MP_APB6LPENCLRR_SPI4LPEN                 \ SPI4 peripherals clocks during CSleep mode If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000008 constant RCC_RCC_MP_APB6LPENCLRR_SPI5LPEN                 \ SPI5 peripherals clocks during CSleep mode If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000010 constant RCC_RCC_MP_APB6LPENCLRR_I2C3LPEN                 \ I2C3 peripherals clocks during CSleep mode If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000020 constant RCC_RCC_MP_APB6LPENCLRR_I2C4LPEN                 \ I2C4 peripherals clocks during CSleep mode If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000040 constant RCC_RCC_MP_APB6LPENCLRR_I2C5LPEN                 \ I2C5 peripherals clocks during CSleep mode If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000080 constant RCC_RCC_MP_APB6LPENCLRR_TIM12LPEN                \ TIM12 peripherals clocks during CSleep mode If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_MP_APB6LPENCLRR_TIM13LPEN                \ TIM13 peripherals clocks during CSleep mode If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000200 constant RCC_RCC_MP_APB6LPENCLRR_TIM14LPEN                \ TIM14 peripherals clocks during CSleep mode If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000400 constant RCC_RCC_MP_APB6LPENCLRR_TIM15LPEN                \ TIM15 peripherals clocks during CSleep mode If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000800 constant RCC_RCC_MP_APB6LPENCLRR_TIM16LPEN                \ TIM16 peripherals clocks during CSleep mode If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00001000 constant RCC_RCC_MP_APB6LPENCLRR_TIM17LPEN                \ TIM17 peripherals clocks during CSleep mode If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x850
\ Reset value: 0x0000017F
\

$00000001 constant RCC_RCC_MP_AHB2LPENSETR_DMA1LPEN                 \ DMA1 peripheral clocks enable during Sleep mode Set by software.
$00000002 constant RCC_RCC_MP_AHB2LPENSETR_DMA2LPEN                 \ DMA2 peripheral clocks enable during Sleep mode Set by software.
$00000004 constant RCC_RCC_MP_AHB2LPENSETR_DMAMUX1LPEN              \ DMAMUX1 peripheral clocks enable during Sleep mode Set by software.
$00000008 constant RCC_RCC_MP_AHB2LPENSETR_DMA3LPEN                 \ DMA3 peripheral clocks enable during Sleep mode If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000010 constant RCC_RCC_MP_AHB2LPENSETR_DMAMUX2LPEN              \ DMAMUX2 peripheral clocks enable during Sleep mode If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000020 constant RCC_RCC_MP_AHB2LPENSETR_ADC1LPEN                 \ ADC1 peripheral clocks enable during Sleep mode If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000040 constant RCC_RCC_MP_AHB2LPENSETR_ADC2LPEN                 \ ADC2 peripheral clocks enable during Sleep mode If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_MP_AHB2LPENSETR_USBOLPEN                 \ USBO peripheral clocks enable during Sleep mode If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x854
\ Reset value: 0x0000017F
\

$00000001 constant RCC_RCC_MP_AHB2LPENCLRR_DMA1LPEN                 \ DMA1 peripheral clocks enable during Sleep mode Cleared by software.
$00000002 constant RCC_RCC_MP_AHB2LPENCLRR_DMA2LPEN                 \ DMA2 peripheral clocks enable during Sleep mode Cleared by software.
$00000004 constant RCC_RCC_MP_AHB2LPENCLRR_DMAMUX1LPEN              \ DMAMUX1 peripheral clocks enable during Sleep mode Cleared by software.
$00000008 constant RCC_RCC_MP_AHB2LPENCLRR_DMA3LPEN                 \ DMA3 peripheral clocks enable during Sleep mode If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000010 constant RCC_RCC_MP_AHB2LPENCLRR_DMAMUX2LPEN              \ DMAMUX2 peripheral clocks enable during Sleep mode If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000020 constant RCC_RCC_MP_AHB2LPENCLRR_ADC1LPEN                 \ ADC1 peripheral clocks enable during Sleep mode If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000040 constant RCC_RCC_MP_AHB2LPENCLRR_ADC2LPEN                 \ ADC2 peripheral clocks enable during Sleep mode If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000100 constant RCC_RCC_MP_AHB2LPENCLRR_USBOLPEN                 \ USBO peripheral clocks enable during Sleep mode If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.


\
\ @brief This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x858
\ Reset value: 0x00008000
\

$00008000 constant RCC_RCC_MP_AHB4LPENSETR_TSCLPEN                  \ TSC peripheral clocks enable during CSleep mode Set by software.


\
\ @brief RCC AHB4 Sleep clock enable clear register
\ Address offset: 0x85C
\ Reset value: 0x00008000
\

$00008000 constant RCC_RCC_MP_AHB4LPENCLRR_TSCLPEN                  \ TSC peripheral clocks enable during CSleep mode Cleared by software.


\
\ @brief This is a secure register, for enabling the clock of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x868
\ Reset value: 0x000001FF
\

$00000001 constant RCC_RCC_MP_S_AHB4LPENSETR_GPIOALPEN              \ GPIOA peripheral clocks enable during CSleep mode Set by (secure) software.
$00000002 constant RCC_RCC_MP_S_AHB4LPENSETR_GPIOBLPEN              \ GPIOB peripheral clocks enable during CSleep mode Set by (secure) software.
$00000004 constant RCC_RCC_MP_S_AHB4LPENSETR_GPIOCLPEN              \ GPIOC peripheral clocks enable during CSleep mode Set by (secure) software.
$00000008 constant RCC_RCC_MP_S_AHB4LPENSETR_GPIODLPEN              \ GPIOD peripheral clocks enable during CSleep mode Set by (secure) software.
$00000010 constant RCC_RCC_MP_S_AHB4LPENSETR_GPIOELPEN              \ GPIOE peripheral clocks enable during CSleep mode Set by (secure) software.
$00000020 constant RCC_RCC_MP_S_AHB4LPENSETR_GPIOFLPEN              \ GPIOF peripheral clocks enable during CSleep mode Set by (secure) software.
$00000040 constant RCC_RCC_MP_S_AHB4LPENSETR_GPIOGLPEN              \ GPIOG peripheral clocks enable during CSleep mode Set by (secure) software.
$00000080 constant RCC_RCC_MP_S_AHB4LPENSETR_GPIOHLPEN              \ GPIOH peripheral clocks enable during CSleep mode Set by (secure) software.
$00000100 constant RCC_RCC_MP_S_AHB4LPENSETR_GPIOILPEN              \ GPIOI peripheral clocks enable during CSleep mode Set by (secure) software.


\
\ @brief This is a secure register, for disabling the clock of the secure (AHB4) GPIO ports
\ Address offset: 0x86C
\ Reset value: 0x000001FF
\

$00000001 constant RCC_RCC_MP_S_AHB4LPENCLRR_GPIOALPEN              \ GPIOA peripheral clocks enable during CSleep mode Cleared by (secure) software.
$00000002 constant RCC_RCC_MP_S_AHB4LPENCLRR_GPIOBLPEN              \ GPIOB peripheral clocks enable during CSleep mode Cleared by (secure) software.
$00000004 constant RCC_RCC_MP_S_AHB4LPENCLRR_GPIOCLPEN              \ GPIOC peripheral clocks enable during CSleep mode Cleared by (secure) software.
$00000008 constant RCC_RCC_MP_S_AHB4LPENCLRR_GPIODLPEN              \ GPIOD peripheral clocks enable during CSleep mode Cleared by (secure) software.
$00000010 constant RCC_RCC_MP_S_AHB4LPENCLRR_GPIOELPEN              \ GPIOE peripheral clocks enable during CSleep mode Cleared by (secure) software.
$00000020 constant RCC_RCC_MP_S_AHB4LPENCLRR_GPIOFLPEN              \ GPIOF peripheral clocks enable during CSleep mode Cleared by (secure) software.
$00000040 constant RCC_RCC_MP_S_AHB4LPENCLRR_GPIOGLPEN              \ GPIOG peripheral clocks enable during CSleep mode Cleared by (secure) software.
$00000080 constant RCC_RCC_MP_S_AHB4LPENCLRR_GPIOHLPEN              \ GPIOH peripheral clocks enable during CSleep mode Cleared by (secure) software.
$00000100 constant RCC_RCC_MP_S_AHB4LPENCLRR_GPIOILPEN              \ GPIOI peripheral clocks enable during CSleep mode Cleared by (secure) software.


\
\ @brief This is a non-secure register, for enabling the clock of the non-secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x870
\ Reset value: 0x000001FF
\

$00000001 constant RCC_RCC_MP_NS_AHB4LPENSETR_GPIOALPEN             \ GPIOA peripheral clocks enable during CSleep mode Set by software.
$00000002 constant RCC_RCC_MP_NS_AHB4LPENSETR_GPIOBLPEN             \ GPIOB peripheral clocks enable during CSleep mode Set by software.
$00000004 constant RCC_RCC_MP_NS_AHB4LPENSETR_GPIOCLPEN             \ GPIOC peripheral clocks enable during CSleep mode Set by software.
$00000008 constant RCC_RCC_MP_NS_AHB4LPENSETR_GPIODLPEN             \ GPIOD peripheral clocks enable during CSleep mode Set by software.
$00000010 constant RCC_RCC_MP_NS_AHB4LPENSETR_GPIOELPEN             \ GPIOE peripheral clocks enable during CSleep mode Set by software.
$00000020 constant RCC_RCC_MP_NS_AHB4LPENSETR_GPIOFLPEN             \ GPIOF peripheral clocks enable during CSleep mode Set by software.
$00000040 constant RCC_RCC_MP_NS_AHB4LPENSETR_GPIOGLPEN             \ GPIOG peripheral clocks enable during CSleep mode Set by software.
$00000080 constant RCC_RCC_MP_NS_AHB4LPENSETR_GPIOHLPEN             \ GPIOH peripheral clocks enable during CSleep mode Set by software.
$00000100 constant RCC_RCC_MP_NS_AHB4LPENSETR_GPIOILPEN             \ GPIOI peripheral clocks enable during CSleep mode Set by software.


\
\ @brief This is a non-secure register, for disabling the clock of the non-secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I).
\ Address offset: 0x874
\ Reset value: 0x000001FF
\

$00000001 constant RCC_RCC_MP_NS_AHB4LPENCLRR_GPIOALPEN             \ GPIOA peripheral clocks enable during CSleep mode Cleared by software.
$00000002 constant RCC_RCC_MP_NS_AHB4LPENCLRR_GPIOBLPEN             \ GPIOB peripheral clocks enable during CSleep mode Cleared by software.
$00000004 constant RCC_RCC_MP_NS_AHB4LPENCLRR_GPIOCLPEN             \ GPIOC peripheral clocks enable during CSleep mode Cleared by software.
$00000008 constant RCC_RCC_MP_NS_AHB4LPENCLRR_GPIODLPEN             \ GPIOD peripheral clocks enable during CSleep mode Cleared by software.
$00000010 constant RCC_RCC_MP_NS_AHB4LPENCLRR_GPIOELPEN             \ GPIOE peripheral clocks enable during CSleep mode Cleared by software.
$00000020 constant RCC_RCC_MP_NS_AHB4LPENCLRR_GPIOFLPEN             \ GPIOF peripheral clocks enable during CSleep mode Cleared by software.
$00000040 constant RCC_RCC_MP_NS_AHB4LPENCLRR_GPIOGLPEN             \ GPIOG peripheral clocks enable during CSleep mode Cleared by software.
$00000080 constant RCC_RCC_MP_NS_AHB4LPENCLRR_GPIOHLPEN             \ GPIOH peripheral clocks enable during CSleep mode Cleared by software.
$00000100 constant RCC_RCC_MP_NS_AHB4LPENCLRR_GPIOILPEN             \ GPIOI peripheral clocks enable during CSleep mode Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x878
\ Reset value: 0x0000017C
\

$00000004 constant RCC_RCC_MP_AHB5LPENSETR_PKALPEN                  \ PKA peripheral clocks enable during CSleep mode If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000008 constant RCC_RCC_MP_AHB5LPENSETR_SAESLPEN                 \ SAES peripheral clocks enable during CSleep mode If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000010 constant RCC_RCC_MP_AHB5LPENSETR_CRYP1LPEN                \ CRYP (3DES/AES) peripheral clocks enable during CSleep mode If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000020 constant RCC_RCC_MP_AHB5LPENSETR_HASH1LPEN                \ HASH peripheral clocks enable during CSleep mode If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000040 constant RCC_RCC_MP_AHB5LPENSETR_RNG1LPEN                 \ RNG1 peripheral clocks enable during CSleep mode If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_MP_AHB5LPENSETR_BKPSRAMLPEN              \ BKPSRAM clocks enable during CSleep mode If BKPSRAM is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x87C
\ Reset value: 0x0000017C
\

$00000004 constant RCC_RCC_MP_AHB5LPENCLRR_PKALPEN                  \ PKA peripheral clocks enable during CSleep mode If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000008 constant RCC_RCC_MP_AHB5LPENCLRR_SAESLPEN                 \ SAES peripheral clocks enable during CSleep mode If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000010 constant RCC_RCC_MP_AHB5LPENCLRR_CRYP1LPEN                \ CRYP (3DES/AES) peripheral clocks enable during CSleep mode If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000020 constant RCC_RCC_MP_AHB5LPENCLRR_HASH1LPEN                \ HASH peripheral clocks enable during CSleep mode If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000040 constant RCC_RCC_MP_AHB5LPENCLRR_RNG1LPEN                 \ RNG1 peripheral clocks enable during CSleep mode If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000100 constant RCC_RCC_MP_AHB5LPENCLRR_BKPSRAMLPEN              \ BKPSRAM clocks enable during CSleep mode If BKPSRAM is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x880
\ Reset value: 0x79135782
\

$00000002 constant RCC_RCC_MP_AHB6LPENSETR_MCELPEN                  \ MCE peripheral clocks enable during CSleep mode If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000080 constant RCC_RCC_MP_AHB6LPENSETR_ETH1CKLPEN               \ Enable of the ETH1 clock generated by the RCC (eth1_ker_ck) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000100 constant RCC_RCC_MP_AHB6LPENSETR_ETH1TXLPEN               \ ETH1 transmission clock enable during CSleep mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000200 constant RCC_RCC_MP_AHB6LPENSETR_ETH1RXLPEN               \ ETH1 reception clock enable during CSleep mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000400 constant RCC_RCC_MP_AHB6LPENSETR_ETH1MACLPEN              \ ETH1 MAC bus interface clock enable during CSleep mode (hclk6 and aclk) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000800 constant RCC_RCC_MP_AHB6LPENSETR_ETH1STPEN                \ ETH1 peripheral clock enable during CStop mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software in order to allow the ETH1 block to receive from pads ETH1_TX_CLK and ETH1_RX_CLK clocks during CStop.
$00001000 constant RCC_RCC_MP_AHB6LPENSETR_FMCLPEN                  \ FMC peripheral clocks enable during CSleep mode If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00004000 constant RCC_RCC_MP_AHB6LPENSETR_QSPILPEN                 \ QUADSPI peripheral clocks enable during CSleep mode If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00010000 constant RCC_RCC_MP_AHB6LPENSETR_SDMMC1LPEN               \ SDMMC1 and SDMMC1 delay (DLYBSD1) block peripheral clocks enable during CSleep mode If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00020000 constant RCC_RCC_MP_AHB6LPENSETR_SDMMC2LPEN               \ SDMMC2 and SDMMC2 delay (DLYBSD2) block peripheral clocks enable during CSleep mode If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00100000 constant RCC_RCC_MP_AHB6LPENSETR_CRC1LPEN                 \ CRC peripheral clocks enable during CSleep mode Set by software.
$01000000 constant RCC_RCC_MP_AHB6LPENSETR_USBHLPEN                 \ USBH peripheral clocks enable during CSleep mode Set by software.
$08000000 constant RCC_RCC_MP_AHB6LPENSETR_ETH2CKLPEN               \ Enable of the ETH2 clock generated by the RCC (eth2_ker_ck) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$10000000 constant RCC_RCC_MP_AHB6LPENSETR_ETH2TXLPEN               \ ETH2 transmission clock enable during CSleep mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$20000000 constant RCC_RCC_MP_AHB6LPENSETR_ETH2RXLPEN               \ ETH2 reception clock enable during CSleep mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$40000000 constant RCC_RCC_MP_AHB6LPENSETR_ETH2MACLPEN              \ ETH2 MAC bus interface clock enable during CSleep mode (hclk6 and aclk) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$80000000 constant RCC_RCC_MP_AHB6LPENSETR_ETH2STPEN                \ ETH2 peripheral clock enable during CStop mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software in order to allow the ETH2 block to receive from pads ETH2_TX_CLK and ETH2_RX_CLK clocks during CStop.


\
\ @brief This register may be separately and securely write-protected at a field level.
\ Address offset: 0x884
\ Reset value: 0x79135782
\

$00000002 constant RCC_RCC_MP_AHB6LPENCLRR_MCELPEN                  \ MCE peripheral clocks enable during CSleep mode If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000080 constant RCC_RCC_MP_AHB6LPENCLRR_ETH1CKLPEN               \ Enable of the ETH1 clock generated by the RCC (eth1_ker_ck) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000100 constant RCC_RCC_MP_AHB6LPENCLRR_ETH1TXLPEN               \ ETH1 transmission clock enable during CSleep mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000200 constant RCC_RCC_MP_AHB6LPENCLRR_ETH1RXLPEN               \ ETH1 reception clock enable during CSleep mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000400 constant RCC_RCC_MP_AHB6LPENCLRR_ETH1MACLPEN              \ ETH1 MAC bus interface clock enable during CSleep mode (hclk6 and aclk) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000800 constant RCC_RCC_MP_AHB6LPENCLRR_ETH1STPEN                \ ETH1 peripheral clock enable during CStop mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software in order to allow the ETH1 block to receive from pads ETH1_TX_CLK and ETH1_RX_CLK clocks during CStop.
$00001000 constant RCC_RCC_MP_AHB6LPENCLRR_FMCLPEN                  \ FMC peripheral clocks enable during CSleep mode If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00004000 constant RCC_RCC_MP_AHB6LPENCLRR_QSPILPEN                 \ QUADSPI peripheral clocks enable during CSleep mode If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00010000 constant RCC_RCC_MP_AHB6LPENCLRR_SDMMC1LPEN               \ SDMMC1 and SDMMC1 delay (DLYBSD1) block peripheral clocks enable during CSleep mode If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00020000 constant RCC_RCC_MP_AHB6LPENCLRR_SDMMC2LPEN               \ SDMMC2 and SDMMC2 delay (DLYBSD2) block peripheral clocks enable during CSleep mode If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00100000 constant RCC_RCC_MP_AHB6LPENCLRR_CRC1LPEN                 \ CRC peripheral clocks enable during CSleep mode Cleared by software.
$01000000 constant RCC_RCC_MP_AHB6LPENCLRR_USBHLPEN                 \ USBH peripheral clocks enable during CSleep mode Cleared by software.
$08000000 constant RCC_RCC_MP_AHB6LPENCLRR_ETH2CKLPEN               \ Enable of the ETH2 clock generated by the RCC (eth2_ker_ck) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$10000000 constant RCC_RCC_MP_AHB6LPENCLRR_ETH2TXLPEN               \ ETH2 transmission clock enable during CSleep mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$20000000 constant RCC_RCC_MP_AHB6LPENCLRR_ETH2RXLPEN               \ ETH2 reception clock enable during CSleep mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$40000000 constant RCC_RCC_MP_AHB6LPENCLRR_ETH2MACLPEN              \ ETH2 MAC bus interface clock enable during CSleep mode (hclk6 and aclk) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$80000000 constant RCC_RCC_MP_AHB6LPENCLRR_ETH2STPEN                \ ETH2 peripheral clock enable during CStop mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software in order to allow the ETH2 block to receive from pads ETH2_TX_CLK and ETH2_RX_CLK clocks during CStop.


\
\ @brief This is a secure register for enabling the clock of the MDMA in Sleep mode when it is used as secure. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x888
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_S_AHB6LPENSETR_MDMALPEN               \ MDMA peripheral clocks enable during CSleep mode Set by (secure) software.


\
\ @brief This is a secure register for disabling the clock of the MDMA in Sleep mode when it is not used as secure. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x88C
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_S_AHB6LPENCLRR_MDMALPEN               \ MDMA peripheral clocks enable during CSleep mode Cleared by (secure) software.


\
\ @brief This is a non-secure register for enabling the clock of the MDMA in Sleep mode when it is not used as secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x890
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_NS_AHB6LPENSETR_MDMALPEN              \ MDMA peripheral clocks enable during CSleep mode Set by software.


\
\ @brief This is a non-secure register for disabling the clock of the MDMA in Sleep mode when it is not used as secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
\ Address offset: 0x894
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_NS_AHB6LPENCLRR_MDMALPEN              \ MDMA peripheral clocks enable during CSleep mode Cleared by software.


\
\ @brief This is a secure register, for enabling the clock of the SYSRAM during CSleep mode. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x898
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_S_AXIMLPENSETR_SYSRAMLPEN             \ SYSRAM interface clock enable during CSleep mode Set by (secure) software.


\
\ @brief This is a secure register, for disabling the clock of the SYSRAM during CSleep mode.
\ Address offset: 0x89C
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_S_AXIMLPENCLRR_SYSRAMLPEN             \ SYSRAM interface clock enable during CSleep mode Cleared by (secure) software.


\
\ @brief This is a non-secure register, for enabling the clock of the SYSRAM during CSleep mode. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x8A0
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_NS_AXIMLPENSETR_SYSRAMLPEN            \ SYSRAM interface clock enable during CSleep mode Set by software.


\
\ @brief This is a non-secure register, for disabling the clock of the SYSRAM during CSleep mode.
\ Address offset: 0x8A4
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_NS_AXIMLPENCLRR_SYSRAMLPEN            \ SYSRAM interface clock enable during CSleep mode Cleared by software.


\
\ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
\ Address offset: 0x8A8
\ Reset value: 0x00000007
\

$00000001 constant RCC_RCC_MP_MLAHBLPENSETR_SRAM1LPEN               \ SRAM1 interface clock enable during CSleep mode If SRAM1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000002 constant RCC_RCC_MP_MLAHBLPENSETR_SRAM2LPEN               \ SRAM2 interface clock enable during CSleep mode If SRAM2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
$00000004 constant RCC_RCC_MP_MLAHBLPENSETR_SRAM3LPEN               \ SRAM3 interface clock enable during CSleep mode If SRAM3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.


\
\ @brief This register may be separately and securely write-protected at a field level
\ Address offset: 0x8AC
\ Reset value: 0x00000007
\

$00000001 constant RCC_RCC_MP_MLAHBLPENCLRR_SRAM1LPEN               \ SRAM1 interface clock enable during CSleep mode If SRAM1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000002 constant RCC_RCC_MP_MLAHBLPENCLRR_SRAM2LPEN               \ SRAM2 interface clock enable during CSleep mode If SRAM2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
$00000004 constant RCC_RCC_MP_MLAHBLPENCLRR_SRAM3LPEN               \ SRAM3 interface clock enable during CSleep mode If SRAM3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.


\
\ @brief This read register reflects at a bit level the secure state of each APB3 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
\ Address offset: 0x8C0
\ Reset value: 0x00004003
\

$00000001 constant RCC_RCC_APB3SECSR_LPTIM2SECF                     \ LPTIM2 block secure status flag This bit reflects the LPTIM2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000002 constant RCC_RCC_APB3SECSR_LPTIM3SECF                     \ LPTIM3 block secure status flag This bit reflects the LPTIM3 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00002000 constant RCC_RCC_APB3SECSR_VREFSECF                       \ VREF block secure status flag This bit reflects the VREF block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.


\
\ @brief This read register reflects at a bit level the secure state of each APB4 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
\ Address offset: 0x8C4
\ Reset value: 0x00010002
\

$00000002 constant RCC_RCC_APB4SECSR_DCMIPPSECF                     \ DCMIPP block secure status flag This bit reflects the DCMIPP block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00010000 constant RCC_RCC_APB4SECSR_USBPHYSECF                     \ USBPHY block secure status flag This bit reflects the USBPHY block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.


\
\ @brief This read register reflects at a bit level the secure state of each APB5 secure or securable peripheral, as configured either via the corresponding DECPROT[1] field of the ETZPC register or via the TrustZone-aware peripheral itself.
\ Address offset: 0x8C8
\ Reset value: 0x0031A800
\

$00000100 constant RCC_RCC_APB5SECSR_RTCSECF                        \ RTC block secure status flag This bit reflects the RTC block secure state. If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), this bit is asserted.
$00000800 constant RCC_RCC_APB5SECSR_TZCSECF                        \ TZC block secure status flag This bit reflects the TZC block secure state.
$00002000 constant RCC_RCC_APB5SECSR_ETZPCSECF                      \ ETZPC block secure status flag This bit reflects the ETZPC block secure state.
$00008000 constant RCC_RCC_APB5SECSR_IWDG1SECF                      \ IWDG1 block secure status flag This bit reflects the IWDG1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00010000 constant RCC_RCC_APB5SECSR_BSECSECF                       \ BSEC block secure status flag This bit reflects the BSEC block secure state.
$00300000 constant RCC_RCC_APB5SECSR_STGENCSECF                     \ STGENC block secure status flag This field reflects the STGENC block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.


\
\ @brief This read register reflects at a bit level the secure state of each APB6 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
\ Address offset: 0x8CC
\ Reset value: 0x00001FFF
\

$00000001 constant RCC_RCC_APB6SECSR_USART1SECF                     \ USART1 block secure status flag This bit reflects the USART1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000002 constant RCC_RCC_APB6SECSR_USART2SECF                     \ USART2 block secure status flag This bit reflects the USART2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000004 constant RCC_RCC_APB6SECSR_SPI4SECF                       \ SPI4 block secure status flag This bit reflects the SPI4 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000008 constant RCC_RCC_APB6SECSR_SPI5SECF                       \ SPI5 block secure status flag This bit reflects the SPI5 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000010 constant RCC_RCC_APB6SECSR_I2C3SECF                       \ I2C3 block secure status flag This bit reflects the I2C3 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000020 constant RCC_RCC_APB6SECSR_I2C4SECF                       \ I2C4 block secure status flag This bit reflects the I2C4 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000040 constant RCC_RCC_APB6SECSR_I2C5SECF                       \ I2C5 block secure status flag This bit reflects the I2C5 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000080 constant RCC_RCC_APB6SECSR_TIM12SECF                      \ TIM12 block secure status flag This bit reflects the TIM12 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000100 constant RCC_RCC_APB6SECSR_TIM13SECF                      \ TIM13 block secure status flag This bit reflects the TIM13 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000200 constant RCC_RCC_APB6SECSR_TIM14SECF                      \ TIM14 block secure status flag This bit reflects the TIM14 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000400 constant RCC_RCC_APB6SECSR_TIM15SECF                      \ TIM15 block secure status flag This bit reflects the TIM15 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000800 constant RCC_RCC_APB6SECSR_TIM16SECF                      \ TIM16 block secure status flag This bit reflects the TIM16 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00001000 constant RCC_RCC_APB6SECSR_TIM17SECF                      \ TIM17 block secure status flag This bit reflects the TIM17 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.


\
\ @brief This read register reflects at a bit level the secure state of each AHB2 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
\ Address offset: 0x8D0
\ Reset value: 0x00000178
\

$00000008 constant RCC_RCC_AHB2SECSR_DMA3SECF                       \ DMA3 block secure status flag This bit reflects the DMA3 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000010 constant RCC_RCC_AHB2SECSR_DMAMUX2SECF                    \ DMAMUX2 block secure status flag This bit reflects the DMAMUX2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000020 constant RCC_RCC_AHB2SECSR_ADC1SECF                       \ ADC1 block secure status flag This bit reflects the ADC1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000040 constant RCC_RCC_AHB2SECSR_ADC2SECF                       \ ADC2 block secure status flag This bit reflects the ADC2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000100 constant RCC_RCC_AHB2SECSR_USBOSECF                       \ USBO block secure status flag This bit reflects the USBO block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.


\
\ @brief This read register reflects at a bit level the secure state of each AHB4 securable peripheral, as configured either via the corresponding DECPROT[1] field of the ETZPC register or via the TrustZone-aware peripheral itself.
\ Address offset: 0x8D4
\ Reset value: 0x00004000
\

$00008000 constant RCC_RCC_AHB4SECSR_TSCSECF                        \ TSC block secure status flag This bit reflects the TSC block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.


\
\ @brief This read register reflects at a bit level the secure state of each AHB5 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
\ Address offset: 0x8D8
\ Reset value: 0x0000017C
\

$00000004 constant RCC_RCC_AHB5SECSR_PKASECF                        \ PKA block secure status flag This bit reflects the PKA block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000008 constant RCC_RCC_AHB5SECSR_SAESSECF                       \ SAES block secure status flag This bit reflects the SAES block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000010 constant RCC_RCC_AHB5SECSR_CRYP1SECF                      \ CRYP1 block secure status flag This bit reflects the CRYP1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000020 constant RCC_RCC_AHB5SECSR_HASH1SECF                      \ HASH1 block secure status flag This bit reflects the HASH1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000040 constant RCC_RCC_AHB5SECSR_RNG1SECF                       \ RNG1 block secure status flag This bit reflects the RNG1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000100 constant RCC_RCC_AHB5SECSR_BKPSRAMSECF                    \ BKPSRAM block secure status flag This bit reflects the BKPSRAM block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.


\
\ @brief This read register reflects at a bit level the secure state of each AHB6 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
\ Address offset: 0x8DC
\ Reset value: 0xF8035F82
\

$00000002 constant RCC_RCC_AHB6SECSR_MCESECF                        \ MCE block secure status flag This bit reflects the MCE block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00000f80 constant RCC_RCC_AHB6SECSR_ETH1SECF                       \ ETH1 block secure status flag This field reflects the ETH1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00001000 constant RCC_RCC_AHB6SECSR_FMCSECF                        \ FMC block secure status flag This bit reflects the FMC block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00004000 constant RCC_RCC_AHB6SECSR_QSPISECF                       \ QSPI block secure status flag This bit reflects the QSPI block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00010000 constant RCC_RCC_AHB6SECSR_SDMMC1SECF                     \ SDMMC1 block secure status flag This bit reflects the SDMMC1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$00020000 constant RCC_RCC_AHB6SECSR_SDMMC2SECF                     \ SDMMC2 block secure status flag This bit reflects the SDMMC2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$f8000000 constant RCC_RCC_AHB6SECSR_ETH2SECF                       \ ETH2 block secure status flag This field reflects the ETH2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.


\
\ @brief This register gives the IP version
\ Address offset: 0xFF4
\ Reset value: 0x00000020
\

$0000000f constant RCC_RCC_VERR_MINREV                              \ Minor Revision of the IP
$000000f0 constant RCC_RCC_VERR_MAJREV                              \ Major Revision of the IP


\
\ @brief This register gives the unique identifier of the RCC
\ Address offset: 0xFF8
\ Reset value: 0x00000001
\

$00000000 constant RCC_RCC_IDR_ID                                   \ Identifier of the RCC


\
\ @brief This register gives the decoding space, which is for the RCC of 4 kB.
\ Address offset: 0xFFC
\ Reset value: 0xA3C5DD04
\

$00000000 constant RCC_RCC_SIDR_SID                                 \ Decoding space is 4 kbytes


\
\ @brief RCC
\
$50000000 constant RCC_RCC_SECCFGR  \ offset: 0x00 : RCC secure configuration register
$50000100 constant RCC_RCC_MP_SREQSETR  \ offset: 0x100 : RCC stop request set register
$50000104 constant RCC_RCC_MP_SREQCLRR  \ offset: 0x104 : RCC stop request clear register
$50000108 constant RCC_RCC_MP_APRSTCR  \ offset: 0x108 : RCC application reset control register
$5000010c constant RCC_RCC_MP_APRSTSR  \ offset: 0x10C : RCC application reset status register
$50000110 constant RCC_RCC_PWRLPDLYCR  \ offset: 0x110 : RCC low-power Stop modes delay control register
$50000114 constant RCC_RCC_MP_GRSTCSETR  \ offset: 0x114 : RCC global reset control set register
$50000118 constant RCC_RCC_BR_RSTSCLRR  \ offset: 0x118 : RCC BOOTROM reset status clear register
$5000011c constant RCC_RCC_MP_RSTSSETR  \ offset: 0x11C : RCC reset status set register
$50000120 constant RCC_RCC_MP_RSTSCLRR  \ offset: 0x120 : RCC reset status clear register
$50000124 constant RCC_RCC_MP_IWDGFZSETR  \ offset: 0x124 : RCC IWDG clock freeze set register
$50000128 constant RCC_RCC_MP_IWDGFZCLRR  \ offset: 0x128 : RCC IWDG clock freeze clear register
$50000200 constant RCC_RCC_MP_CIER  \ offset: 0x200 : RCC clock source interrupt enable register
$50000204 constant RCC_RCC_MP_CIFR  \ offset: 0x204 : RCC clock source interrupt flag register
$50000400 constant RCC_RCC_BDCR   \ offset: 0x400 : RCC backup domain control register
$50000404 constant RCC_RCC_RDLSICR  \ offset: 0x404 : RCC reset duration and LSI control register
$50000420 constant RCC_RCC_OCENSETR  \ offset: 0x420 : RCC oscillator clock enable set register
$50000424 constant RCC_RCC_OCENCLRR  \ offset: 0x424 : RCC oscillator clock enable clear register
$50000428 constant RCC_RCC_OCRDYR  \ offset: 0x428 : RCC oscillators and MPU and AXI clock ready register
$50000440 constant RCC_RCC_HSICFGR  \ offset: 0x440 : RCC HSI configuration register
$50000444 constant RCC_RCC_CSICFGR  \ offset: 0x444 : RCC CSI configuration register
$50000460 constant RCC_RCC_MCO1CFGR  \ offset: 0x460 : RCC MCO1 configuration register
$50000464 constant RCC_RCC_MCO2CFGR  \ offset: 0x464 : RCC MCO2 configuration register
$50000468 constant RCC_RCC_DBGCFGR  \ offset: 0x468 : RCC debug configuration register
$50000480 constant RCC_RCC_RCK12SELR  \ offset: 0x480 : RCC PLL1 and PLL2 reference clock selection register
$50000484 constant RCC_RCC_RCK3SELR  \ offset: 0x484 : RCC PLL3 reference clock selection register
$50000488 constant RCC_RCC_RCK4SELR  \ offset: 0x488 : RCC PLL4 reference clock selection register
$500004a0 constant RCC_RCC_PLL1CR  \ offset: 0x4A0 : RCC PLL1 control register
$500004a4 constant RCC_RCC_PLL1CFGR1  \ offset: 0x4A4 : RCC PLL1 configuration register 1
$500004a8 constant RCC_RCC_PLL1CFGR2  \ offset: 0x4A8 : RCC PLL1 configuration register 2
$500004ac constant RCC_RCC_PLL1FRACR  \ offset: 0x4AC : RCC PLL1 fractional register
$500004b0 constant RCC_RCC_PLL1CSGR  \ offset: 0x4B0 : RCC PLL1 clock spreading generator register
$500004d0 constant RCC_RCC_PLL2CR  \ offset: 0x4D0 : RCC PLL2 control register
$500004d4 constant RCC_RCC_PLL2CFGR1  \ offset: 0x4D4 : RCC PLL2 configuration register 1
$500004d8 constant RCC_RCC_PLL2CFGR2  \ offset: 0x4D8 : RCC PLL2 configuration register 2
$500004dc constant RCC_RCC_PLL2FRACR  \ offset: 0x4DC : RCC PLL2 fractional register
$500004e0 constant RCC_RCC_PLL2CSGR  \ offset: 0x4E0 : RCC PLL2 clock spreading generator register
$50000500 constant RCC_RCC_PLL3CR  \ offset: 0x500 : RCC PLL3 control register
$50000504 constant RCC_RCC_PLL3CFGR1  \ offset: 0x504 : RCC PLL3 configuration register 1
$50000508 constant RCC_RCC_PLL3CFGR2  \ offset: 0x508 : RCC PLL3 configuration register 2
$5000050c constant RCC_RCC_PLL3FRACR  \ offset: 0x50C : RCC PLL3 Fractional register
$50000510 constant RCC_RCC_PLL3CSGR  \ offset: 0x510 : RCC PLL3 clock spreading generator register
$50000520 constant RCC_RCC_PLL4CR  \ offset: 0x520 : RCC PLL4 control register
$50000524 constant RCC_RCC_PLL4CFGR1  \ offset: 0x524 : RCC PLL4 configuration register 1
$50000528 constant RCC_RCC_PLL4CFGR2  \ offset: 0x528 : RCC PLL4 configuration register 2
$5000052c constant RCC_RCC_PLL4FRACR  \ offset: 0x52C : RCC PLL4 fractional register
$50000530 constant RCC_RCC_PLL4CSGR  \ offset: 0x530 : RCC PLL4 clock spreading generator register
$50000540 constant RCC_RCC_MPCKSELR  \ offset: 0x540 : RCC MPU clock selection register
$50000544 constant RCC_RCC_ASSCKSELR  \ offset: 0x544 : RCC AXI sub-system clock selection register.
$50000548 constant RCC_RCC_MSSCKSELR  \ offset: 0x548 : RCC MLAHB sub-system clock selection register
$5000054c constant RCC_RCC_CPERCKSELR  \ offset: 0x54C : RCC common peripheral kernel clock selection register
$50000560 constant RCC_RCC_RTCDIVR  \ offset: 0x560 : RCC RTC clock division register
$50000564 constant RCC_RCC_MPCKDIVR  \ offset: 0x564 : RCC MPU clock divider register
$50000568 constant RCC_RCC_AXIDIVR  \ offset: 0x568 : RCC AXI clock divider register
$5000056c constant RCC_RCC_MLAHBDIVR  \ offset: 0x56C : RCC MLAHB clock divider register
$50000570 constant RCC_RCC_APB1DIVR  \ offset: 0x570 : RCC APB1 clock divider register
$50000574 constant RCC_RCC_APB2DIVR  \ offset: 0x574 : RCC APB2 clock divider register
$50000578 constant RCC_RCC_APB3DIVR  \ offset: 0x578 : RCC APB3 clock divider register
$5000057c constant RCC_RCC_APB4DIVR  \ offset: 0x57C : RCC APB4 clock divider register.
$50000580 constant RCC_RCC_APB5DIVR  \ offset: 0x580 : RCC APB5 clock divider register
$50000584 constant RCC_RCC_APB6DIVR  \ offset: 0x584 : RCC APB6 clock divider register
$500005a0 constant RCC_RCC_TIMG1PRER  \ offset: 0x5A0 : RCC APB1 timers group1 prescaler register.
$500005a4 constant RCC_RCC_TIMG2PRER  \ offset: 0x5A4 : RCC APB2 timers group2 prescaler register
$500005a8 constant RCC_RCC_TIMG3PRER  \ offset: 0x5A8 : RCC APB6 timers group3 prescaler register
$500005c0 constant RCC_RCC_DDRITFCR  \ offset: 0x5C0 : RCC DDR interface control register
$50000600 constant RCC_RCC_I2C12CKSELR  \ offset: 0x600 : RCC I2C1 and I2C2 kernel clock selection register
$50000604 constant RCC_RCC_I2C345CKSELR  \ offset: 0x604 : RCC I2C3, I2C4 and I2C5 kernel clock selection register.
$50000608 constant RCC_RCC_SPI2S1CKSELR  \ offset: 0x608 : RCC SPI/I2S1 kernel clock selection register
$5000060c constant RCC_RCC_SPI2S23CKSELR  \ offset: 0x60C : RCC SPI/I2S2 and SPI/I2S3 kernel clock selection register
$50000610 constant RCC_RCC_SPI45CKSELR  \ offset: 0x610 : RCC SPI/I2S4 and SPI5 kernel clock selection register
$50000614 constant RCC_RCC_UART12CKSELR  \ offset: 0x614 : RCC USART1 and USART2 kernel clock selection register
$50000618 constant RCC_RCC_UART35CKSELR  \ offset: 0x618 : RCC USART3 and UART5 kernel clock selection register
$5000061c constant RCC_RCC_UART4CKSELR  \ offset: 0x61C : RCC UART4 kernel clock selection register
$50000620 constant RCC_RCC_UART6CKSELR  \ offset: 0x620 : RCC USART6 kernel clock selection register
$50000624 constant RCC_RCC_UART78CKSELR  \ offset: 0x624 : RCC UART7 and UART8 kernel clock selection register
$50000628 constant RCC_RCC_LPTIM1CKSELR  \ offset: 0x628 : RCC LPTIM1 kernel clock selection register
$5000062c constant RCC_RCC_LPTIM23CKSELR  \ offset: 0x62C : RCC LPTIM2 and LPTIM3 kernel clock selection register
$50000630 constant RCC_RCC_LPTIM45CKSELR  \ offset: 0x630 : RCC LPTIM4 and LPTIM5 kernel clock selection register
$50000634 constant RCC_RCC_SAI1CKSELR  \ offset: 0x634 : RCC SAI1 kernel clock selection register
$50000638 constant RCC_RCC_SAI2CKSELR  \ offset: 0x638 : RCC SAI2 kernel clock selection register
$5000063c constant RCC_RCC_FDCANCKSELR  \ offset: 0x63C : RCC FDCAN kernel clock selection register
$50000640 constant RCC_RCC_SPDIFCKSELR  \ offset: 0x640 : RCC SPDIFRX kernel clock selection register
$50000644 constant RCC_RCC_ADC12CKSELR  \ offset: 0x644 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the (AHB2) ADC1 and ADC2 blocks. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
$50000648 constant RCC_RCC_SDMMC12CKSELR  \ offset: 0x648 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the (AHB6) SDMMC1 and SDMMC2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
$5000064c constant RCC_RCC_ETH12CKSELR  \ offset: 0x64C : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the ETH1 and ETH2 blocks. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
$50000650 constant RCC_RCC_USBCKSELR  \ offset: 0x650 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the USBPHY PLL of the USB Host (USBH) and the USB On-The-Go (USBO). It also controls the pre-divider for the reference clock for the USBPHY. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
$50000654 constant RCC_RCC_QSPICKSELR  \ offset: 0x654 : If (AHB6) QUADSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the QUADSPI. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
$50000658 constant RCC_RCC_FMCCKSELR  \ offset: 0x658 : If (AHB6) FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the FMC block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
$5000065c constant RCC_RCC_RNG1CKSELR  \ offset: 0x65C : If (AHB5) RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the RNG1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
$50000660 constant RCC_RCC_STGENCKSELR  \ offset: 0x660 : If (APB5) STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. STGEN is a dual APB interface IP, with STGENC APB5 controller part which may be secure or non-secure depending on the corresponding DECPROT[1]. Its other STGENRO APB4 read-only interface is non-secure. This register is used to select the peripheral clock for the STGEN block. Note that this clock is used to provide a time reference for the application. Refer to SectionÂ : Clock enabling delays.
$50000664 constant RCC_RCC_DCMIPPCKSELR  \ offset: 0x664 : If (APB4) DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the DCMIPP block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
$50000668 constant RCC_RCC_SAESCKSELR  \ offset: 0x668 : If (AHB5) SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the SAES block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
$500006a0 constant RCC_RCC_APB1RSTSETR  \ offset: 0x6A0 : This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
$500006a4 constant RCC_RCC_APB1RSTCLRR  \ offset: 0x6A4 : This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
$500006a8 constant RCC_RCC_APB2RSTSETR  \ offset: 0x6A8 : This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
$500006ac constant RCC_RCC_APB2RSTCLRR  \ offset: 0x6AC : This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
$500006b0 constant RCC_RCC_APB3RSTSETR  \ offset: 0x6B0 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
$500006b4 constant RCC_RCC_APB3RSTCLRR  \ offset: 0x6B4 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
$500006b8 constant RCC_RCC_APB4RSTSETR  \ offset: 0x6B8 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
$500006bc constant RCC_RCC_APB4RSTCLRR  \ offset: 0x6BC : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
$500006c0 constant RCC_RCC_APB5RSTSETR  \ offset: 0x6C0 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
$500006c4 constant RCC_RCC_APB5RSTCLRR  \ offset: 0x6C4 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
$500006c8 constant RCC_RCC_APB6RSTSETR  \ offset: 0x6C8 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
$500006cc constant RCC_RCC_APB6RSTCLRR  \ offset: 0x6CC : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
$500006d0 constant RCC_RCC_AHB2RSTSETR  \ offset: 0x6D0 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
$500006d4 constant RCC_RCC_AHB2RSTCLRR  \ offset: 0x6D4 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
$500006e0 constant RCC_RCC_AHB4RSTSETR  \ offset: 0x6E0 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
$500006e4 constant RCC_RCC_AHB4RSTCLRR  \ offset: 0x6E4 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
$500006e8 constant RCC_RCC_AHB5RSTSETR  \ offset: 0x6E8 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
$500006ec constant RCC_RCC_AHB5RSTCLRR  \ offset: 0x6EC : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
$500006f0 constant RCC_RCC_AHB6RSTSETR  \ offset: 0x6F0 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
$500006f4 constant RCC_RCC_AHB6RSTCLRR  \ offset: 0x6F4 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
$50000700 constant RCC_RCC_MP_APB1ENSETR  \ offset: 0x700 : This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective value of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000704 constant RCC_RCC_MP_APB1ENCLRR  \ offset: 0x704 : This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000708 constant RCC_RCC_MP_APB2ENSETR  \ offset: 0x708 : This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000070c constant RCC_RCC_MP_APB2ENCLRR  \ offset: 0x70C : This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to â0â.
$50000710 constant RCC_RCC_MP_APB3ENSETR  \ offset: 0x710 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000714 constant RCC_RCC_MP_APB3ENCLRR  \ offset: 0x714 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000718 constant RCC_RCC_MP_S_APB3ENSETR  \ offset: 0x718 : This is a secure register for enabling the clock of the SYSCFG.
$5000071c constant RCC_RCC_MP_S_APB3ENCLRR  \ offset: 0x71C : This is a secure register for disabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000720 constant RCC_RCC_MP_NS_APB3ENSETR  \ offset: 0x720 : This is a non-secure register, for enabling the clock of the SYSCFG.
$50000724 constant RCC_RCC_MP_NS_APB3ENCLRR  \ offset: 0x724 : This is a non-secure register, for disabling the clock of the SYSCFG.
$50000728 constant RCC_RCC_MP_APB4ENSETR  \ offset: 0x728 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000072c constant RCC_RCC_MP_APB4ENCLRR  \ offset: 0x72C : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000730 constant RCC_RCC_MP_S_APB4ENSETR  \ offset: 0x730 : This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000734 constant RCC_RCC_MP_S_APB4ENCLRR  \ offset: 0x734 : This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer.
$50000738 constant RCC_RCC_MP_NS_APB4ENSETR  \ offset: 0x738 : This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000073c constant RCC_RCC_MP_NS_APB4ENCLRR  \ offset: 0x73C : This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers.
$50000740 constant RCC_RCC_MP_APB5ENSETR  \ offset: 0x740 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000744 constant RCC_RCC_MP_APB5ENCLRR  \ offset: 0x744 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000748 constant RCC_RCC_MP_APB6ENSETR  \ offset: 0x748 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000074c constant RCC_RCC_MP_APB6ENCLRR  \ offset: 0x74C : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000750 constant RCC_RCC_MP_AHB2ENSETR  \ offset: 0x750 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000754 constant RCC_RCC_MP_AHB2ENCLRR  \ offset: 0x754 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000760 constant RCC_RCC_MP_AHB4ENSETR  \ offset: 0x760 : This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000764 constant RCC_RCC_MP_AHB4ENCLRR  \ offset: 0x764 : This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000768 constant RCC_RCC_MP_S_AHB4ENSETR  \ offset: 0x768 : This is a secure register, for enabling the clock of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000076c constant RCC_RCC_MP_S_AHB4ENCLRR  \ offset: 0x76C : This is a secure register, for disabling of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000770 constant RCC_RCC_MP_NS_AHB4ENSETR  \ offset: 0x770 : This is a non-secure register, for enabling the non-secure GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000774 constant RCC_RCC_MP_NS_AHB4ENCLRR  \ offset: 0x774 : This is a non-secure register, for disabling the non-secure GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000778 constant RCC_RCC_MP_AHB5ENSETR  \ offset: 0x778 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral to the MPU. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000077c constant RCC_RCC_MP_AHB5ENCLRR  \ offset: 0x77C : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000780 constant RCC_RCC_MP_AHB6ENSETR  \ offset: 0x780 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000784 constant RCC_RCC_MP_AHB6ENCLRR  \ offset: 0x784 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000788 constant RCC_RCC_MP_S_AHB6ENSETR  \ offset: 0x788 : This is a secure register for enabling the clock of the MDMA when it is used as secure. A write access to this register field must be secure. A read access may be secure or non- secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000078c constant RCC_RCC_MP_S_AHB6ENCLRR  \ offset: 0x78C : This is a secure register for disabling the clock of the MDMA when it is not used as secure. A write access to this register field must be secure. A read access may be secure or non- secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000790 constant RCC_RCC_MP_NS_AHB6ENSETR  \ offset: 0x790 : This is a non-secure register for enabling the clock of the MDMA when it is used as non- secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000794 constant RCC_RCC_MP_NS_AHB6ENCLRR  \ offset: 0x794 : This is a non-secure register for disabling the clock of the MDMA when it is not used as non- secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000800 constant RCC_RCC_MP_APB1LPENSETR  \ offset: 0x800 : This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000804 constant RCC_RCC_MP_APB1LPENCLRR  \ offset: 0x804 : This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000808 constant RCC_RCC_MP_APB2LPENSETR  \ offset: 0x808 : This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000080c constant RCC_RCC_MP_APB2LPENCLRR  \ offset: 0x80C : This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000810 constant RCC_RCC_MP_APB3LPENSETR  \ offset: 0x810 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000814 constant RCC_RCC_MP_APB3LPENCLRR  \ offset: 0x814 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000818 constant RCC_RCC_MP_S_APB3LPENSETR  \ offset: 0x818 : This is a secure register for enabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000081c constant RCC_RCC_MP_S_APB3LPENCLRR  \ offset: 0x81C : This is a secure register for disabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000820 constant RCC_RCC_MP_NS_APB3LPENSETR  \ offset: 0x820 : This is a non-secure register, for enabling the clock of the SYSCFG. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000824 constant RCC_RCC_MP_NS_APB3LPENCLRR  \ offset: 0x824 : This is a non-secure register, for disabling the clock of the SYSCFG. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000828 constant RCC_RCC_MP_APB4LPENSETR  \ offset: 0x828 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000082c constant RCC_RCC_MP_APB4LPENCLRR  \ offset: 0x82C : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000830 constant RCC_RCC_MP_S_APB4LPENSETR  \ offset: 0x830 : This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000834 constant RCC_RCC_MP_S_APB4LPENCLRR  \ offset: 0x834 : This is a secure register for disabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000838 constant RCC_RCC_MP_NS_APB4LPENSETR  \ offset: 0x838 : This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000083c constant RCC_RCC_MP_NS_APB4LPENCLRR  \ offset: 0x83C : This is a non-secure register, for disabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000840 constant RCC_RCC_MP_APB5LPENSETR  \ offset: 0x840 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000844 constant RCC_RCC_MP_APB5LPENCLRR  \ offset: 0x844 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000848 constant RCC_RCC_MP_APB6LPENSETR  \ offset: 0x848 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000084c constant RCC_RCC_MP_APB6LPENCLRR  \ offset: 0x84C : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000850 constant RCC_RCC_MP_AHB2LPENSETR  \ offset: 0x850 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000854 constant RCC_RCC_MP_AHB2LPENCLRR  \ offset: 0x854 : This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000858 constant RCC_RCC_MP_AHB4LPENSETR  \ offset: 0x858 : This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000085c constant RCC_RCC_MP_AHB4LPENCLRR  \ offset: 0x85C : RCC AHB4 Sleep clock enable clear register
$50000868 constant RCC_RCC_MP_S_AHB4LPENSETR  \ offset: 0x868 : This is a secure register, for enabling the clock of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000086c constant RCC_RCC_MP_S_AHB4LPENCLRR  \ offset: 0x86C : This is a secure register, for disabling the clock of the secure (AHB4) GPIO ports
$50000870 constant RCC_RCC_MP_NS_AHB4LPENSETR  \ offset: 0x870 : This is a non-secure register, for enabling the clock of the non-secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000874 constant RCC_RCC_MP_NS_AHB4LPENCLRR  \ offset: 0x874 : This is a non-secure register, for disabling the clock of the non-secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I).
$50000878 constant RCC_RCC_MP_AHB5LPENSETR  \ offset: 0x878 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000087c constant RCC_RCC_MP_AHB5LPENCLRR  \ offset: 0x87C : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000880 constant RCC_RCC_MP_AHB6LPENSETR  \ offset: 0x880 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000884 constant RCC_RCC_MP_AHB6LPENCLRR  \ offset: 0x884 : This register may be separately and securely write-protected at a field level.
$50000888 constant RCC_RCC_MP_S_AHB6LPENSETR  \ offset: 0x888 : This is a secure register for enabling the clock of the MDMA in Sleep mode when it is used as secure. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000088c constant RCC_RCC_MP_S_AHB6LPENCLRR  \ offset: 0x88C : This is a secure register for disabling the clock of the MDMA in Sleep mode when it is not used as secure. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000890 constant RCC_RCC_MP_NS_AHB6LPENSETR  \ offset: 0x890 : This is a non-secure register for enabling the clock of the MDMA in Sleep mode when it is not used as secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$50000894 constant RCC_RCC_MP_NS_AHB6LPENCLRR  \ offset: 0x894 : This is a non-secure register for disabling the clock of the MDMA in Sleep mode when it is not used as secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
$50000898 constant RCC_RCC_MP_S_AXIMLPENSETR  \ offset: 0x898 : This is a secure register, for enabling the clock of the SYSRAM during CSleep mode. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$5000089c constant RCC_RCC_MP_S_AXIMLPENCLRR  \ offset: 0x89C : This is a secure register, for disabling the clock of the SYSRAM during CSleep mode.
$500008a0 constant RCC_RCC_MP_NS_AXIMLPENSETR  \ offset: 0x8A0 : This is a non-secure register, for enabling the clock of the SYSRAM during CSleep mode. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$500008a4 constant RCC_RCC_MP_NS_AXIMLPENCLRR  \ offset: 0x8A4 : This is a non-secure register, for disabling the clock of the SYSRAM during CSleep mode.
$500008a8 constant RCC_RCC_MP_MLAHBLPENSETR  \ offset: 0x8A8 : This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
$500008ac constant RCC_RCC_MP_MLAHBLPENCLRR  \ offset: 0x8AC : This register may be separately and securely write-protected at a field level
$500008c0 constant RCC_RCC_APB3SECSR  \ offset: 0x8C0 : This read register reflects at a bit level the secure state of each APB3 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$500008c4 constant RCC_RCC_APB4SECSR  \ offset: 0x8C4 : This read register reflects at a bit level the secure state of each APB4 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$500008c8 constant RCC_RCC_APB5SECSR  \ offset: 0x8C8 : This read register reflects at a bit level the secure state of each APB5 secure or securable peripheral, as configured either via the corresponding DECPROT[1] field of the ETZPC register or via the TrustZone-aware peripheral itself.
$500008cc constant RCC_RCC_APB6SECSR  \ offset: 0x8CC : This read register reflects at a bit level the secure state of each APB6 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$500008d0 constant RCC_RCC_AHB2SECSR  \ offset: 0x8D0 : This read register reflects at a bit level the secure state of each AHB2 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$500008d4 constant RCC_RCC_AHB4SECSR  \ offset: 0x8D4 : This read register reflects at a bit level the secure state of each AHB4 securable peripheral, as configured either via the corresponding DECPROT[1] field of the ETZPC register or via the TrustZone-aware peripheral itself.
$500008d8 constant RCC_RCC_AHB5SECSR  \ offset: 0x8D8 : This read register reflects at a bit level the secure state of each AHB5 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$500008dc constant RCC_RCC_AHB6SECSR  \ offset: 0x8DC : This read register reflects at a bit level the secure state of each AHB6 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
$50000ff4 constant RCC_RCC_VERR   \ offset: 0xFF4 : This register gives the IP version
$50000ff8 constant RCC_RCC_IDR    \ offset: 0xFF8 : This register gives the unique identifier of the RCC
$50000ffc constant RCC_RCC_SIDR   \ offset: 0xFFC : This register gives the decoding space, which is for the RCC of 4 kB.

