\
\ @file rcc.fs
\ @brief RCC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RCC_DEF

  [ifdef] RCC_RCC_SECCFGR_DEF
    \
    \ @brief RCC secure configuration register
    \ Address offset: 0x00
    \ Reset value: 0x83FF3F1F
    \
    $00 constant RCC_HSISEC                     \ [0x00] Secure state of the HSI clock
    $01 constant RCC_CSISEC                     \ [0x01] Secure state of the CSI clock
    $02 constant RCC_HSESEC                     \ [0x02] Secure state of the HSE clock
    $03 constant RCC_LSISEC                     \ [0x03] Secure state of the LSI clock
    $04 constant RCC_LSESEC                     \ [0x04] Secure state of the LSE clock
    $08 constant RCC_PLL12SEC                   \ [0x08] Secure state of the PLL1 and PLL2 clocks
    $09 constant RCC_PLL3SEC                    \ [0x09] Secure state of the PLL3 clock
    $0a constant RCC_PLL4SEC                    \ [0x0a] Secure state of the PLL4 clock
    $0b constant RCC_MPUSEC                     \ [0x0b] Secure state of the MPU sub-system clock
    $0c constant RCC_AXISEC                     \ [0x0c] Secure state of the AXI sub-system clock
    $0d constant RCC_MLAHBSEC                   \ [0x0d] Secure state of the MLAHB sub-system clock
    $10 constant RCC_APB3DIVSEC                 \ [0x10] Secure state of the APB3DIV divider
    $11 constant RCC_APB4DIVSEC                 \ [0x11] Secure state of the APB4DIV divider
    $12 constant RCC_APB5DIVSEC                 \ [0x12] Secure state of the APB5DIV divider
    $13 constant RCC_APB6DIVSEC                 \ [0x13] Secure state of the APB6DIV divider
    $14 constant RCC_TIMG3SEC                   \ [0x14] Secure state of the TIMG3 prescaler
    $15 constant RCC_CPERSEC                    \ [0x15] Secure state of the common peripheral clock
    $16 constant RCC_MCO1SEC                    \ [0x16] Secure state of the MCO1 clock
    $17 constant RCC_MCO2SEC                    \ [0x17] Secure state of the MCO2 clock
    $18 constant RCC_STPSEC                     \ [0x18] Secure state of the Stop modes
    $19 constant RCC_RSTSEC                     \ [0x19] Secure state of the reset
    $1f constant RCC_PWRSEC                     \ [0x1f] Secure state of the PWR block This control bit generates the output signal rcc_pwr_sec which is connected to the PWR block.
  [then]


  [ifdef] RCC_RCC_MP_SREQSETR_DEF
    \
    \ @brief RCC stop request set register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant RCC_STPREQ_P0                  \ [0x00] Stop request from MPU processor Set by software Indicates if the MPU processor allow or not the entry in CStop/CStandby modes for MPU domain, when the MPU is in WFI. Note: the entry selection between CStop and CStandby is controlled by PWR_MPUCR.PDDS and PWR_CR1.STOP2 control bits.
  [then]


  [ifdef] RCC_RCC_MP_SREQCLRR_DEF
    \
    \ @brief RCC stop request clear register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant RCC_STPREQ_P0                  \ [0x00] Stop request from MPU processor Cleared by software Indicates if the MPU processor allow or not the entry in CStop/CStandby modes for MPU domain, when the MPU is in WFI. Note: the entry selection between CStop and CStandby is controlled by PWR_MPUCR.PDDS and PWR_CR1.STOP2 control bits.
  [then]


  [ifdef] RCC_RCC_MP_APRSTCR_DEF
    \
    \ @brief RCC application reset control register
    \ Address offset: 0x108
    \ Reset value: 0x00007F00
    \
    $00 constant RCC_RDCTLEN                    \ [0x00] Reset delay control enable Set and reset by software.
    $08 constant RCC_RSTTO                      \ [0x08 : 7] Reset timeout delay adjust
  [then]


  [ifdef] RCC_RCC_MP_APRSTSR_DEF
    \
    \ @brief RCC application reset status register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $08 constant RCC_RSTTOV                     \ [0x08 : 7] Reset timeout delay value Set by hardware in order to give the value of the timeout counter. This function is only available when the RDCTLEN = '1'. If RSTTOS = '0' it means that a timeout occurred.
  [then]


  [ifdef] RCC_RCC_PWRLPDLYCR_DEF
    \
    \ @brief RCC low-power Stop modes delay control register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PWRLP_DLY                  \ [0x00 : 22] PWRLP_TEMPO value Written by software. This register contains the delay value to be observed before activating the PLLs and interconnect clocks, after one of the system Stop modes. The delay is counted with the HSI clock. The user has to take into account HSIDIV value. The delay value is given by the following formula: PWRLP_DLY[21:0] / FHSI ...
  [then]


  [ifdef] RCC_RCC_MP_GRSTCSETR_DEF
    \
    \ @brief RCC global reset control set register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MPSYSRST                   \ [0x00] System reset Set by software, cleared by hardware.
    $04 constant RCC_MPUP0RST                   \ [0x04] MPU processor reset Set by software, cleared by hardware when the reset command is completed. Note that the Snoop Control Unit of the MPU (SCU) is not reset.
  [then]


  [ifdef] RCC_RCC_BR_RSTSCLRR_DEF
    \
    \ @brief RCC BOOTROM reset status clear register
    \ Address offset: 0x118
    \ Reset value: 0x00000015
    \
    $00 constant RCC_PORRSTF                    \ [0x00] POR/PDR reset flag Cleared by software, set by hardware when a POR/PDR reset occurred.
    $01 constant RCC_BORRSTF                    \ [0x01] BOR reset flag Cleared by software, set by hardware when a BOR reset occurred.
    $02 constant RCC_PADRSTF                    \ [0x02] NRST reset flag Cleared by software, set by hardware when a PAD reset occurred.
    $03 constant RCC_HCSSRSTF                   \ [0x03] HSE CSS reset flag Cleared by software, set by hardware when a failure is detected on HSE.
    $04 constant RCC_VCORERSTF                  \ [0x04] VDDCORE reset flag Cleared by software, set by hardware when a reset occurred because VDDCORE is lower than the expected value.
    $05 constant RCC_VCPURSTF                   \ [0x05] VDDCPU reset flag Cleared by software, set by hardware when a reset occurred because VDDCPU is lower than the expected value.
    $06 constant RCC_MPSYSRSTF                  \ [0x06] MPU System reset flag Cleared by software, set by hardware when a MPU system reset occurred.
    $08 constant RCC_IWDG1RSTF                  \ [0x08] IWDG1 reset flag Cleared by software, set by hardware when a IWDG1 reset occurred.
    $09 constant RCC_IWDG2RSTF                  \ [0x09] IWDG2 reset flag Cleared by software, set by hardware when a IWDG2 reset occurred.
    $0d constant RCC_MPUP0RSTF                  \ [0x0d] MPU processor reset flag Cleared by software, set by hardware when a MPU processor reset occurred.
  [then]


  [ifdef] RCC_RCC_MP_RSTSSETR_DEF
    \
    \ @brief RCC reset status set register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PORRSTF                    \ [0x00] POR/PDR reset flag Set by the BOOTROM code when a POR/PDR reset occurred.
    $01 constant RCC_BORRSTF                    \ [0x01] BOR reset flag Set by the BOOTROM code when a BOR reset occurred.
    $02 constant RCC_PADRSTF                    \ [0x02] NRST reset flag Set by the BOOTROM code when a PAD reset occurred.
    $03 constant RCC_HCSSRSTF                   \ [0x03] HSE CSS reset flag Set by the BOOTROM code when a failure is detected on HSE.
    $04 constant RCC_VCORERSTF                  \ [0x04] VDDCORE reset flag Set by the BOOTROM code when a reset occurred because VDDCORE is lower than the expected value.
    $05 constant RCC_VCPURSTF                   \ [0x05] VCPU reset flag Set by the BOOTROM code when a reset occurred because VCPU is lower than the expected value.
    $06 constant RCC_MPSYSRSTF                  \ [0x06] MPU System reset flag Set by the BOOTROM code when a MPU system reset occurred.
    $08 constant RCC_IWDG1RSTF                  \ [0x08] IWDG1 reset flag Set by the BOOTROM code when a IWDG1 reset occurred.
    $09 constant RCC_IWDG2RSTF                  \ [0x09] IWDG2 reset flag Set by the BOOTROM code when a IWDG2 reset occurred.
    $0a constant RCC_STP2RSTF                   \ [0x0a] Stop2 reset flag Set by the BOOTROM code when exiting from Stop2.
    $0b constant RCC_STDBYRSTF                  \ [0x0b] System Standby reset flag Set by the BOOTROM code when exiting from Standby.
    $0c constant RCC_CSTDBYRSTF                 \ [0x0c] MPU CStandby reset flag Set by the BOOTROM code when the MPU exits from CStandby.
    $0d constant RCC_MPUP0RSTF                  \ [0x0d] MPU processor reset flag Set by the BOOTROM code when a MPU processor reset occurred.
    $0f constant RCC_SPARE                      \ [0x0f] Spare bit Set and reset by software. Reserved for future use.
  [then]


  [ifdef] RCC_RCC_MP_RSTSCLRR_DEF
    \
    \ @brief RCC reset status clear register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PORRSTF                    \ [0x00] POR/PDR reset flag Cleared by software, set by the BOOTROM code when a POR/PDR reset occurred.
    $01 constant RCC_BORRSTF                    \ [0x01] BOR reset flag Cleared by software, set by the BOOTROM code when a BOR reset occurred.
    $02 constant RCC_PADRSTF                    \ [0x02] NRST reset flag Cleared by software, set by the BOOTROM code when a PAD reset occurred.
    $03 constant RCC_HCSSRSTF                   \ [0x03] HSE CSS reset flag Cleared by software, set by the BOOTROM code when a failure is detected on HSE.
    $04 constant RCC_VCORERSTF                  \ [0x04] VDDCORE reset flag Cleared by software, set by the BOOTROM code when a reset occurred because VDDCORE is lower than the expected value.
    $05 constant RCC_VCPURSTF                   \ [0x05] VDDCPU reset flag Cleared by software, set by the BOOTROM code when a reset occurred because VDDCPU is lower than the expected value.
    $06 constant RCC_MPSYSRSTF                  \ [0x06] MPU System reset flag Cleared by software, set by the BOOTROM code when a MPU system reset occurred.
    $08 constant RCC_IWDG1RSTF                  \ [0x08] IWDG1 reset flag Cleared by software, set by the BOOTROM code when a IWDG1 reset occurred.
    $09 constant RCC_IWDG2RSTF                  \ [0x09] IWDG2 reset flag Cleared by software, set by the BOOTROM code when a IWDG2 reset occurred.
    $0a constant RCC_STP2RSTF                   \ [0x0a] Stop2 reset flag Cleared by software, set by the BOOTROM code when exiting from Stop2.
    $0b constant RCC_STDBYRSTF                  \ [0x0b] System Standby reset flag Cleared by software, set by the BOOTROM code when exiting from Standby.
    $0c constant RCC_CSTDBYRSTF                 \ [0x0c] MPU CStandby reset flag Cleared by software, set by the BOOTROM code when the MPU exits from CStandby.
    $0d constant RCC_MPUP0RSTF                  \ [0x0d] MPU processor reset flag Cleared by software, set by the BOOTROM code when a MPU processor reset occurred.
    $0f constant RCC_SPARE                      \ [0x0f] Spare bit Set and reset by software. Reserved for future use.
  [then]


  [ifdef] RCC_RCC_MP_IWDGFZSETR_DEF
    \
    \ @brief RCC IWDG clock freeze set register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FZ_IWDG1                   \ [0x00] Freeze the IWDG1 clock If IWDG1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set once by the BOOTROM software after a system reset or Standby reset, or a CStandby reset, in order to freeze the IWDG1.
    $01 constant RCC_FZ_IWDG2                   \ [0x01] Freeze the IWDG2 clock Set once by the BOOTROM software after a system reset or Standby reset, or a CStandby reset, in order to freeze the IWDG2.
  [then]


  [ifdef] RCC_RCC_MP_IWDGFZCLRR_DEF
    \
    \ @brief RCC IWDG clock freeze clear register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FZ_IWDG1                   \ [0x00] Unfreeze the IWDG1 clock If IWDG1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by the BOOTROM software, in order to unfreeze the IWDG1.
    $01 constant RCC_FZ_IWDG2                   \ [0x01] Unfreeze the IWDG2 clock Cleared by the BOOTROM software, in order to unfreeze the IWDG2.
  [then]


  [ifdef] RCC_RCC_MP_CIER_DEF
    \
    \ @brief RCC clock source interrupt enable register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready Interrupt Enable If RCC_SECCFGR.LSISEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the LSI oscillator stabilization.
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready Interrupt Enable If RCC_SECCFGR.LSESEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the LSE oscillator stabilization.
    $02 constant RCC_HSIRDYIE                   \ [0x02] HSI ready Interrupt Enable If RCC_SECCFGR.HSISEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the HSI oscillator stabilization.
    $03 constant RCC_HSERDYIE                   \ [0x03] HSE ready Interrupt Enable If RCC_SECCFGR.HSESEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the HSE oscillator stabilization.
    $04 constant RCC_CSIRDYIE                   \ [0x04] CSI ready Interrupt Enable If RCC_SECCFGR.CSISEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the CSI oscillator stabilization.
    $08 constant RCC_PLL1DYIE                   \ [0x08] PLL1 ready Interrupt Enable If RCC_SECCFGR.PLL12SEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by PLL1 lock.
    $09 constant RCC_PLL2DYIE                   \ [0x09] PLL2 ready Interrupt Enable If RCC_SECCFGR.PLL12SEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by PLL2 lock.
    $0a constant RCC_PLL3DYIE                   \ [0x0a] PLL3 ready Interrupt Enable If RCC_SECCFGR.PLL3SEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by PLL3 lock.
    $0b constant RCC_PLL4DYIE                   \ [0x0b] PLL4 ready Interrupt Enable If RCC_SECCFGR.PLL4SEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by PLL4 lock.
    $10 constant RCC_LSECSSIE                   \ [0x10] LSE clock security system Interrupt Enable If RCC_SECCFGR.LSESEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable interrupt caused by the Clock Security System on external 32 kHz oscillator.
    $14 constant RCC_WKUPIE                     \ [0x14] Wake up from CStop Interrupt Enable If RCC_SECCFGR.STPSEC, a write access to this field must be secure. A read access may be secure or non-secure. Set and reset by software to enable/disable the generation of the interrupt used to wake up the MPU from CStop.
  [then]


  [ifdef] RCC_RCC_MP_CIFR_DEF
    \
    \ @brief RCC clock source interrupt flag register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the LSI clock becomes stable.
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the LSE clock becomes stable.
    $02 constant RCC_HSIRDYF                    \ [0x02] HSI ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the HSI clock becomes stable.
    $03 constant RCC_HSERDYF                    \ [0x03] HSE ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the HSE clock becomes stable.
    $04 constant RCC_CSIRDYF                    \ [0x04] CSI ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the CSI clock becomes stable.
    $08 constant RCC_PLL1DYF                    \ [0x08] PLL1 ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the PLL1 locks.
    $09 constant RCC_PLL2DYF                    \ [0x09] PLL2 ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the PLL2 locks.
    $0a constant RCC_PLL3DYF                    \ [0x0a] PLL3 ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the PLL3 locks.
    $0b constant RCC_PLL4DYF                    \ [0x0b] PLL4 ready Interrupt Flag If RCC_SECCFGR.PLLSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the PLL4 locks.
    $10 constant RCC_LSECSSF                    \ [0x10] LSE clock security system Interrupt Flag If RCC_SECCFGR.LSESEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when a failure is detected on the external 32 kHz oscillator.
    $14 constant RCC_WKUPF                      \ [0x14] Wake up from CStop Interrupt Flag If RCC_SECCFGR.STPSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reset by software by writing this flag to '1'. Set by hardware when the MPU needs to exit from CStop.
  [then]


  [ifdef] RCC_RCC_BDCR_DEF
    \
    \ @brief RCC backup domain control register
    \ Address offset: 0x400
    \ Reset value: 0x00000020
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enabled Set and reset by software. If RCC_SECCFGR.LSESEC, a write access to this register field must be secure. A read access may be secure or non-secure.
    $01 constant RCC_LSEBYP                     \ [0x01] LSE oscillator bypass Set and reset by software to bypass oscillator in debug mode. If RCC_SECCFGR.LSESEC, a write access to this register field must be secure. A read access may be secure or non-secure. This bit must not be written when the LSE is enabled (LSEON = '1'). Refer to Stop. for details.
    $02 constant RCC_LSERDY                     \ [0x02] LSE oscillator ready Set and reset by hardware to indicate when the LSE is stable. This bit needs 6 cycles of lse_ck clock to fall down after LSEON has been set to '0'.
    $03 constant RCC_DIGBYP                     \ [0x03] LSE digital bypass Set and reset by software to select the analog or digital bypass mode. If RCC_SECCFGR.LSESEC, a write access to this register field must be secure. A read access may be secure or non-secure.
    $04 constant RCC_LSEDRV                     \ [0x04 : 2] LSE oscillator driving capability Written by software to select the driving capability of the LSE oscillator. If RCC_SECCFGR.LSESEC, a write access to this register field must be secure. A read access may be secure or non-secure.
    $08 constant RCC_LSECSSON                   \ [0x08] LSE clock security system enable Set by software to enable the Clock Security System on 32 kHz oscillator. If RCC_SECCFGR.LSESEC, a write access to this register field must be secure. A read access may be secure or non-secure. Refer to for details on the activation and deactivation sequences. Once the LSECSSON bit is enabled it cannot be disabled, except after a LSE failure detection (LSECSSD = '1').
    $09 constant RCC_LSECSSD                    \ [0x09] LSE clock security system failure detection Set by hardware to indicate when a failure has been detected by the Clock Security System on the external 32 kHz oscillator.
    $10 constant RCC_RTCSRC                     \ [0x10 : 2] RTC clock source selection Set by software to select the clock source for the RTC. If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure. This field can be written only one time after backup domain reset. When a LSE failure occurs, the RTCSRC[1:0] is set to '00', and the software is allowed to write it again once. This field must be written before LSECSSON is enabled. Refer to for details.
    $14 constant RCC_RTCCKEN                    \ [0x14] RTC clock enable Set and reset by software. If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure.
    $1f constant RCC_VSWRST                     \ [0x1f] VSW domain software reset Set and reset by software. If RCC_SECCFGR.RSTSEC, a write access to this field must be secure. A read access may be secure or non-secure.
  [then]


  [ifdef] RCC_RCC_RDLSICR_DEF
    \
    \ @brief RCC reset duration and LSI control register
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSION                      \ [0x00] LSI oscillator enabled Set and reset by software. If RCC_SECCFGR.LSISEC, a write access to this field must be secure. A read access may be secure or non-secure. This bit is used to request the activation of the LSI oscillator. Note that IWDG1 and IWDG2 can also request the activation of LSI.
    $01 constant RCC_LSIRDY                     \ [0x01] LSI oscillator ready Set and reset by hardware to indicate when the LSI is stable. This bit needs 3 cycles of lsi_ck clock to fall down after LSION has been set to '0'.
    $10 constant RCC_MRD                        \ [0x10 : 5] Minimum reset duration Written by software. If RCC_SECCFGR.RSTSEC, a write access to this field must be secure. A read access may be secure or non-secure. This field defines the minimum guaranteed duration of the NRST low pulse. The LSI oscillator is automatically enabled when needed by the RPCTL. ...
    $18 constant RCC_EADLY                      \ [0x18 : 3] External access delays Written by software. If RCC_SECCFGR.RSTSEC, a write access to this field must be secure. A read access may be secure or non-secure. Time to wait before the BOOTROM performs any external access (UART, USB, QUADSPI, FMC, SDMMC,...)
    $1b constant RCC_SPARE                      \ [0x1b : 5] Spare bits Written by software. If RCC_SECCFGR.RSTSEC, a write access to this field must be secure. A read access may be secure or non-secure. Reserved for future use.
  [then]


  [ifdef] RCC_RCC_OCENSETR_DEF
    \
    \ @brief RCC oscillator clock enable set register
    \ Address offset: 0x420
    \ Reset value: 0x00000001
    \
    $00 constant RCC_HSION                      \ [0x00] Set HSION bit Set by software to enable the HSI clock. This bit must be written by a secure agent if the HSI clock is configured as secure (i.e. if RCC_SECCFGR.HSISEC=1). The HSION is also set by hardware to force the HSI to ON when the product leaves Standby mode or one of the Stop modes.
    $01 constant RCC_HSIKERON                   \ [0x01] Set HSIKERON bit Set by software to force the HSI to ON, even in (LP-)Stop mode, in order to be quickly available as kernel clock for peripherals. This bit must be written by a secure agent if the HSI clock is configured as secure (i.e. if RCC_SECCFGR.HSISEC=1). This bit has no effect on the value of HSION.
    $04 constant RCC_CSION                      \ [0x04] Set CSION bit Set by software to enable CSI clock. This bit must be written by a secure agent if the CSI clock is configured as secure (i.e. if RCC_SECCFGR.CSISEC=1).
    $05 constant RCC_CSIKERON                   \ [0x05] Set CSIKERON bit Set by software to force the CSI to ON, even in (LP-)Stop mode, in order to be quickly available as kernel clock for some peripherals. This bit must be written by a secure agent if the CSI clock is configured as secure (i.e. if RCC_SECCFGR.CSISEC=1). This bit has no effect on the value of CSION.
    $07 constant RCC_DIGBYP                     \ [0x07] Set DIGBYP bit Set by software when the external HSE clock is connected to OSC_IN as a full-swing digital signal. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
    $08 constant RCC_HSEON                      \ [0x08] Set HSEON bit Set by software to enable the HSE. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
    $09 constant RCC_HSEKERON                   \ [0x09] Set HSEKERON bit Set by software to force the HSE to ON, even in (LP-)Stop mode, in order to be quickly available as kernel clock for some peripherals. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1). This bit has no effect on the value of HSEON.
    $0a constant RCC_HSEBYP                     \ [0x0a] Set HSEBYP bit Set by software in order to enable the bypass mode. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
    $0b constant RCC_HSECSSON                   \ [0x0b] Set the HSECSSON bit
  [then]


  [ifdef] RCC_RCC_OCENCLRR_DEF
    \
    \ @brief RCC oscillator clock enable clear register
    \ Address offset: 0x424
    \ Reset value: 0x00000001
    \
    $00 constant RCC_HSION                      \ [0x00] Clear of HSION bit Cleared by software to disable the HSI clock. This bit must be written by a secure agent if the HSI clock is configured as secure (i.e. if RCC_SECCFGR.HSISEC=1).
    $01 constant RCC_HSIKERON                   \ [0x01] Clear of HSIKERON bit Cleared by software in order to allow the HSI to be switched off in one of the Stop modes. This bit must be written by a secure agent if the HSI clock is configured as secure (i.e. if RCC_SECCFGR.HSISEC=1). This bit has no effect on the value of HSION.
    $04 constant RCC_CSION                      \ [0x04] Clear of CSION bit Cleared by software to disable the CSI clock. This bit must be written by a secure agent if the CSI clock is configured as secure (i.e. if RCC_SECCFGR.CSISEC=1).
    $05 constant RCC_CSIKERON                   \ [0x05] Clear of CSIKERON bit Cleared by software in order to allow the CSI to be switched off in one of the Stop modes. This bit must be written by a secure agent if the CSI clock is configured as secure (i.e. if RCC_SECCFGR.CSISEC=1). This bit has no effect on the value of CSION.
    $07 constant RCC_DIGBYP                     \ [0x07] Clear of DIGBYP bit Cleared by software when the external clock connected to OSC_IN is a low-swing signal. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
    $08 constant RCC_HSEON                      \ [0x08] Clear of HSEON bit Cleared by software to disable the HSE clock. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
    $09 constant RCC_HSEKERON                   \ [0x09] Clear HSEKERON bit Cleared by software in order to allow the HSE to be switched off in one of the Stop modes. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
    $0a constant RCC_HSEBYP                     \ [0x0a] Clear the HSEBYP bit Cleared by software in order to disable the bypass mode. This bit must be written by a secure agent if the HSE clock is configured as secure (i.e. if RCC_SECCFGR.HSESEC=1).
  [then]


  [ifdef] RCC_RCC_OCRDYR_DEF
    \
    \ @brief RCC oscillators and MPU and AXI clock ready register
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSIRDY                     \ [0x00] HSI clock ready flag Set by hardware to indicate that the HSI oscillator is stable.
    $02 constant RCC_HSIDIVRDY                  \ [0x02] HSI divider ready flag Set and reset by hardware. As a write in HSIDIV has not an immediate effect on the frequency, this flag indicates the current status of the HSI divider. HSIDIVF will go immediately to '0' when HSIDIV value is changed, and will be set back to '1' when the output frequency matches the value programmed into HSIDIV
    $04 constant RCC_CSIRDY                     \ [0x04] CSI clock ready flag Set by hardware to indicate that the CSI oscillator is stable.
    $08 constant RCC_HSERDY                     \ [0x08] HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable.
    $17 constant RCC_MPUCKRDY                   \ [0x17] MPU clock ready flag Set by hardware to indicate that the mpuss_ck clock is available.
    $18 constant RCC_AXICKRDY                   \ [0x18] AXI sub-system clock ready flag Set by hardware to indicate that the axiss_ck clock is available.
  [then]


  [ifdef] RCC_RCC_HSICFGR_DEF
    \
    \ @brief RCC HSI configuration register
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSIDIV                     \ [0x00 : 2] HSI clock divider Written by software. These bits allows the user to select a division ratio in order to select the wanted HSI clock frequency. The bit HSIDIVRDY of (RCC_OCRDYR) indicates when the new division ratio is taken into account.
    $08 constant RCC_HSITRIM                    \ [0x08 : 7] HSI clock trimming Set by software to adjust calibration. HSITRIM represents a signed value. HSITRIM field is added to the engineering Option Bytes loaded during reset phase (bsec_hsi_cal[11:0]) in order to form the calibration trimming value. HSICAL[11:0] = HSITRIM[6:0] + bsec_hsi_cal[11:0]. ... ...
    $10 constant RCC_HSICAL                     \ [0x10 : 12] HSI clock calibration Set by hardware by option byte loading during system reset Adjusted by software through trimming bits HSITRIM. This field represents the sum of engineering Option Byte calibration value and HSITRIM bits value.
  [then]


  [ifdef] RCC_RCC_CSICFGR_DEF
    \
    \ @brief RCC CSI configuration register
    \ Address offset: 0x444
    \ Reset value: 0x00001000
    \
    $08 constant RCC_CSITRIM                    \ [0x08 : 5] CSI clock trimming Set by software to adjust calibration. CSITRIM field is added to the engineering Option Bytes loaded during reset phase (bsec_csi_cal[7:0]) in order to form the calibration trimming value. CSICAL[7:0] = CSITRIM[4:0] + bsec_csi_cal[7:0].
    $10 constant RCC_CSICAL                     \ [0x10 : 8] CSI clock calibration Set by hardware by option byte loading during system reset. Adjusted by software through trimming bits CSITRIM. This field represents the sum of engineering Option Byte calibration value and CSITRIM bits value
  [then]


  [ifdef] RCC_RCC_MCO1CFGR_DEF
    \
    \ @brief RCC MCO1 configuration register
    \ Address offset: 0x460
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MCO1SEL                    \ [0x00 : 3] MCO1 clock output selection Set and cleared by software. Clock source selection may generate glitches on MCO1. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
    $04 constant RCC_MCO1DIV                    \ [0x04 : 4] MCO1 prescaler Set and cleared by software to configure the prescaler of the MCO1. Modification of this prescaler may generate glitches on MCO1. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. Refer to for details. ...
    $0c constant RCC_MCO1ON                     \ [0x0c] Control of the MCO1 output Set and cleared by software to enable the MCO1 output
  [then]


  [ifdef] RCC_RCC_MCO2CFGR_DEF
    \
    \ @brief RCC MCO2 configuration register
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MCO2SEL                    \ [0x00 : 3] Micro-controller clock output 2 Set and cleared by software. Clock source selection may generate glitches on MCO2. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
    $04 constant RCC_MCO2DIV                    \ [0x04 : 4] MCO2 prescaler Set and cleared by software to configure the prescaler of the MCO2. Modification of this prescaler may generate glitches on MCO2. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. Refer to Section1.4.4: Clock Output generation (MCO1 & MCO2) for details. ...
    $0c constant RCC_MCO2ON                     \ [0x0c] Control of the MCO2 output Set and cleared by software to enable the MCO2 output
  [then]


  [ifdef] RCC_RCC_DBGCFGR_DEF
    \
    \ @brief RCC debug configuration register
    \ Address offset: 0x468
    \ Reset value: 0x00000001
    \
    $00 constant RCC_TRACEDIV                   \ [0x00 : 3] Clock divider for the trace clock (ck_trace) Written by software to control the ck_trace clock division factor. It is possible to change this division ratio on-the-fly. others: aclk / 16
    $08 constant RCC_DBGCKEN                    \ [0x08] Clock enable for debug function Set and cleared by software to control the generation of the ck_apb_dbg clock (DEBUG APB clock), the ck_sys_dbg. See for additional information.
    $09 constant RCC_TRACECKEN                  \ [0x09] Clock enable for trace function Set and cleared by software to control the generation of the trace_ck clock. See for additional information.
    $0c constant RCC_DBGRST                     \ [0x0c] Reset of the debug function Set and cleared by software to control the generation of the reset (dbg_rstn) for the trace and debug parts.
  [then]


  [ifdef] RCC_RCC_RCK12SELR_DEF
    \
    \ @brief RCC PLL1 and PLL2 reference clock selection register
    \ Address offset: 0x480
    \ Reset value: 0x80000000
    \
    $00 constant RCC_PLL12SRC                   \ [0x00 : 2] Source clock selection for PLL12 Written by software to select the PLL12 source clock. In order to save power when PLL12 is not used, PLL12SRC[1:0] must be set to '1x'. others: No clock send to DIVM1 divider and PLL12
    $1f constant RCC_PLL12SRCRDY                \ [0x1f] PLL12 source clock switch status Set and reset by hardware to indicate if the PLL12 clock switch transition has been properly performed.
  [then]


  [ifdef] RCC_RCC_RCK3SELR_DEF
    \
    \ @brief RCC PLL3 reference clock selection register
    \ Address offset: 0x484
    \ Reset value: 0x80000000
    \
    $00 constant RCC_PLL3SRC                    \ [0x00 : 2] Source clock selection for PLL3 Written by software to select the PLL3 clock source. In order to save power, when PLL3 is not used, PLL3SRC[1:0] must be set to '11'.
    $1f constant RCC_PLL3SRCRDY                 \ [0x1f] PLL3 source clock switch status Set and reset by hardware to indicate if the PLL3 clock switch transition has been properly performed.
  [then]


  [ifdef] RCC_RCC_RCK4SELR_DEF
    \
    \ @brief RCC PLL4 reference clock selection register
    \ Address offset: 0x488
    \ Reset value: 0x80000000
    \
    $00 constant RCC_PLL4SRC                    \ [0x00 : 2] Source clock selection for PLL4 Written by software to select the PLL4 clock source.
    $1f constant RCC_PLL4SRCRDY                 \ [0x1f] PLL4 source clock switch status Set and reset by hardware to indicate if the PLL4 clock switch transition has been properly performed.
  [then]


  [ifdef] RCC_RCC_PLL1CR_DEF
    \
    \ @brief RCC PLL1 control register
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLLON                      \ [0x00] PLL1 enable.
    $01 constant RCC_PLL1RDY                    \ [0x01] PLL1 clock ready flag Set by hardware to indicate that the PLL1 is locked.
    $02 constant RCC_SSCG_CTRL                  \ [0x02] Spread Spectrum Clock Generator of PLL1 enable Set and reset by software to enable the spread spectrum clock generator of PLL1, in order to reduce the amount of EMI peaks.
    $04 constant RCC_DIVPEN                     \ [0x04] PLL1 DIVP divider output enable Set and reset by software to enable the pll1_p_ck output of the PLL1. In order to save power, when the pll1_p_ck is not needed, DIVPEN and DIVP must be set to '0'.
    $05 constant RCC_DIVQEN                     \ [0x05] PLL1 DIVQ divider output enable Set and reset by software to enable the pll1_q_ck output of the PLL1. In order to save power, when the pll1_q_ck is not needed, DIVQEN and DIVQ must be set to '0'.
    $06 constant RCC_DIVREN                     \ [0x06] PLL1 DIVR divider output enable Set and reset by software to enable the pll1_r_ck output of the PLL1. In order to save power, when the pll1_r_ck is not needed, DIVREN and DIVR must be set to '0'.
  [then]


  [ifdef] RCC_RCC_PLL1CFGR1_DEF
    \
    \ @brief RCC PLL1 configuration register 1
    \ Address offset: 0x4A4
    \ Reset value: 0x00010031
    \
    $00 constant RCC_DIVN                       \ [0x00 : 9] Multiplication factor for PLL1 VCO Written by software to control the multiplication factor of the VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is: 992 to 1800 MHz. VCO output frequency = Fref1_ck x 2 x (DIVN+1), when value 0 has been loaded into FRACV, with: - Valid division ratios for DIVN: between 25 and 100 - The input frequency Fref1_ck between 8 and 16 MHz ... ... Others: wrong configurations
    $10 constant RCC_DIVM1                      \ [0x10 : 6] Prescaler for PLL1 Set and cleared by software to configure the prescaler of the PLL1. ...
  [then]


  [ifdef] RCC_RCC_PLL1CFGR2_DEF
    \
    \ @brief RCC PLL1 configuration register 2
    \ Address offset: 0x4A8
    \ Reset value: 0x00010100
    \
    $00 constant RCC_DIVP                       \ [0x00 : 7] PLL1 DIVP division factor Written by software to control the frequency of the pll1_p_ck clock. Odd division factors are not recommended due to duty cycle degradation. ...
    $08 constant RCC_DIVQ                       \ [0x08 : 7] PLL1 DIVQ division factor Written by software to control the frequency of the pll1_q_ck clock. ...
    $10 constant RCC_DIVR                       \ [0x10 : 7] PLL1 DIVR division factor Written by software to control the frequency of the pll1_r_ck clock. ...
  [then]


  [ifdef] RCC_RCC_PLL1FRACR_DEF
    \
    \ @brief RCC PLL1 fractional register
    \ Address offset: 0x4AC
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACV                      \ [0x03 : 13] Fractional part of the multiplication factor for PLL1 VCO Written by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is: 800 to 1600 MHz VCO output frequency = Fref1_ck x ((DIVN+1) + (FRACV / 8192)), with - DIVN shall be between 4 and 512 - FRACV can be between 0 and 8191 - The input frequency Fref1_ck shall be between 4 and 16 MHz In order to change the FRACV value on-the-fly even if the PLL is enabled, the application has to proceed as follow: - set the bit FRACLE to '0', - write the new fractional value into FRACV, - set the bit FRACLE to '1'.
    $10 constant RCC_FRACLE                     \ [0x10] PLL1 fractional latch enable Set and reset by software to latch the content of FRACV into the Sigma-Delta modulator. In order to latch the FRACV value into the Sigma-Delta modulator, FRACLE must be set to '0', then set to '1': the transition 0 to '1' transfers the content of FRACV into the modulator. Refer to and for additional information on the PLL programming.
  [then]


  [ifdef] RCC_RCC_PLL1CSGR_DEF
    \
    \ @brief RCC PLL1 clock spreading generator register
    \ Address offset: 0x4B0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MOD_PER                    \ [0x00 : 13] Modulation Period Adjustment for PLL1 Written by software to adjust the modulation period of the clock spreading generator.
    $0d constant RCC_TPDFN_DIS                  \ [0x0d] Dithering TPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
    $0e constant RCC_RPDFN_DIS                  \ [0x0e] Dithering RPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
    $0f constant RCC_SSCG_MODE                  \ [0x0f] Spread spectrum clock generator mode Set and reset by software to select the clock spreading mode.
    $10 constant RCC_INC_STEP                   \ [0x10 : 15] Modulation Depth Adjustment for PLL1 Written by software to adjust the modulation depth of the clock spreading generator.
  [then]


  [ifdef] RCC_RCC_PLL2CR_DEF
    \
    \ @brief RCC PLL2 control register
    \ Address offset: 0x4D0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLLON                      \ [0x00] PLL2 enable Set and cleared by software to enable the PLL2.
    $01 constant RCC_PLL2RDY                    \ [0x01] PLL2 clock ready flag Set by hardware to indicate that the PLL2 is locked.
    $02 constant RCC_SSCG_CTRL                  \ [0x02] Clock Spreading Generator of PLL2 enable Set and reset by software to enable the clock spreading generator of PLL2, in order to reduce the amount of EMI peaks.
    $04 constant RCC_DIVPEN                     \ [0x04] PLL2 DIVP divider output enable Set and reset by software to enable the pll2_p_ck output of the PLL2. In order to save power, when the pll2_p_ck is not needed, DIVPEN and DIVP must be set to '0'.
    $05 constant RCC_DIVQEN                     \ [0x05] PLL2 DIVQ divider output enable Set and reset by software to enable the pll2_q_ck output of the PLL2. In order to save power, when the pll2_q_ck is not needed, DIVQEN and DIVQ must be set to '0'.
    $06 constant RCC_DIVREN                     \ [0x06] PLL2 DIVR divider output enable Set and reset by software to enable the pll2_r_ck output of the PLL2. In order to save power, when the pll2_r_ck is not needed, DIVREN and DIVR must be set to '0'.
  [then]


  [ifdef] RCC_RCC_PLL2CFGR1_DEF
    \
    \ @brief RCC PLL2 configuration register 1
    \ Address offset: 0x4D4
    \ Reset value: 0x00010063
    \
    $00 constant RCC_DIVN                       \ [0x00 : 9] Multiplication factor for PLL2 VCO Written by software to control the multiplication factor of the VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is: 800 to 1600 MHz. VCO output frequency = Fref2_ck x (DIVN+1), when value 0 has been loaded into FRACV, with: - Valid division ratios for DIVN: between 25 and 100 - The input frequency Fref2_ck between 8 and 16 MHz Others: wrong configurations ... ...
    $10 constant RCC_DIVM2                      \ [0x10 : 6] Prescaler for PLL2 Set and cleared by software to configure the prescaler of the PLL2. ...
  [then]


  [ifdef] RCC_RCC_PLL2CFGR2_DEF
    \
    \ @brief RCC PLL2 configuration register 2
    \ Address offset: 0x4D8
    \ Reset value: 0x00010101
    \
    $00 constant RCC_DIVP                       \ [0x00 : 7] PLL2 DIVP division factor Written by software to control the frequency of the pll2_p_ck clock. ...
    $08 constant RCC_DIVQ                       \ [0x08 : 7] PLL2 DIVQ division factor Written by software to control the frequency of the pll2_q_ck clock. ...
    $10 constant RCC_DIVR                       \ [0x10 : 7] PLL2 DIVR division factor Written by software to control the frequency of the pll2_r_ck clock. ...
  [then]


  [ifdef] RCC_RCC_PLL2FRACR_DEF
    \
    \ @brief RCC PLL2 fractional register
    \ Address offset: 0x4DC
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACV                      \ [0x03 : 13] Fractional part of the multiplication factor for PLL2 VCO Written by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is: 800 to 1600 MHz VCO output frequency = Fref2_ck x ((DIVN+1) + (FRACV / 8192)), with - DIVN shall be between 4 and 512 - FRACV can be between 0 and 8191 - The input frequency Fref2_ck shall be between 4 and 16 MHz In order to change the FRACV value on-the-fly even if the PLL is enabled, the application has to proceed as follow: - set the bit FRACLE to '0', - write the new fractional value into FRACV, - set the bit FRACLE to '1'.
    $10 constant RCC_FRACLE                     \ [0x10] PLL2 fractional latch enable Set and reset by software to latch the content of FRACV into the Sigma-Delta modulator. In order to latch the FRACV value into the Sigma-Delta modulator, FRACLE must be set to '0', then set to '1': the transition 0 to '1' transfers the content of FRACV into the modulator. Refer to and for additional information on the PLL programming.
  [then]


  [ifdef] RCC_RCC_PLL2CSGR_DEF
    \
    \ @brief RCC PLL2 clock spreading generator register
    \ Address offset: 0x4E0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MOD_PER                    \ [0x00 : 13] Modulation Period Adjustment for PLL2 Written by software to adjust the modulation period of the clock spreading generator.
    $0d constant RCC_TPDFN_DIS                  \ [0x0d] Dithering TPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
    $0e constant RCC_RPDFN_DIS                  \ [0x0e] Dithering RPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
    $0f constant RCC_SSCG_MODE                  \ [0x0f] Spread spectrum clock generator mode Set and reset by software to select the clock spreading mode.
    $10 constant RCC_INC_STEP                   \ [0x10 : 15] Modulation Depth Adjustment for PLL2 Written by software to adjust the modulation depth of the clock spreading generator.
  [then]


  [ifdef] RCC_RCC_PLL3CR_DEF
    \
    \ @brief RCC PLL3 control register
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLLON                      \ [0x00] PLL3 enable
    $01 constant RCC_PLL3RDY                    \ [0x01] PLL3 clock ready flag Set by hardware to indicate that the PLL3 is locked.
    $02 constant RCC_SSCG_CTRL                  \ [0x02] Clock Spreading Generator of PLL3 enable Set and reset by software to enable the clock spreading generator of PLL3, in order to reduce the amount of EMI peaks.
    $04 constant RCC_DIVPEN                     \ [0x04] PLL3 DIVP divider output enable Set and reset by software to enable the pll3_p_ck output of the PLL3. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll3_p_ck is not needed, DIVPEN and DIVP must be set to '0'.
    $05 constant RCC_DIVQEN                     \ [0x05] PLL3 DIVQ divider output enable Set and reset by software to enable the pll3_q_ck output of the PLL3. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll3_q_ck is not needed, DIVQEN and DIVQ must be set to '0'.
    $06 constant RCC_DIVREN                     \ [0x06] PLL3 DIVR divider output enable Set and reset by software to enable the pll3_r_ck output of the PLL3. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll3_r_ck is not needed, DIVREN and DIVR must be set to '0'.
  [then]


  [ifdef] RCC_RCC_PLL3CFGR1_DEF
    \
    \ @brief RCC PLL3 configuration register 1
    \ Address offset: 0x504
    \ Reset value: 0x00010031
    \
    $00 constant RCC_DIVN                       \ [0x00 : 9] Multiplication factor for PLL3 VCO Written by software to control the multiplication factor of the VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is between 400 and 800 MHz. VCO output frequency = Fref3_ck x (DIVN+1), when value 0 has been loaded into FRACV, with: - Valid division ratios for DIVN: between 25 and 200 - The input frequency Fref3_ck between 4 and 16 MHz ... ... Others: wrong configurations
    $10 constant RCC_DIVM3                      \ [0x10 : 6] Prescaler for PLL3 Set and cleared by software to configure the prescaler of the PLL3. ...
    $18 constant RCC_IFRGE                      \ [0x18 : 2] PLL3 input frequency range Written by software to select the proper reference frequency range used for PLL3. x0: The PLL3 input (ref3_ck) clock range frequency is between 4 and 8 MHz (default after reset) x1: The PLL3 input (ref3_ck) clock range frequency is between 8 and 16 MHz. Note that if ref3_ck is equal to 8Â MHz, it is recommended to set IFRGE = 'x1â
  [then]


  [ifdef] RCC_RCC_PLL3CFGR2_DEF
    \
    \ @brief RCC PLL3 configuration register 2
    \ Address offset: 0x508
    \ Reset value: 0x00010101
    \
    $00 constant RCC_DIVP                       \ [0x00 : 7] PLL3 DIVP division factor Written by software to control the frequency of the pll3_p_ck clock. ...
    $08 constant RCC_DIVQ                       \ [0x08 : 7] PLL3 DIVQ division factor Written by software to control the frequency of the pll3_q_ck clock. ...
    $10 constant RCC_DIVR                       \ [0x10 : 7] PLL3 DIVR division factor Written by software to control the frequency of the pll3_r_ck clock. ...
  [then]


  [ifdef] RCC_RCC_PLL3FRACR_DEF
    \
    \ @brief RCC PLL3 Fractional register
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACV                      \ [0x03 : 13] Fractional part of the multiplication factor for PLL3 VCO Written by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is between 400 and 800 MHz. VCO output frequency = Fref3_ck x ((DIVN+1) + (FRACV / 8192)), with - DIVN shall be between 4 and 512 - FRACV can be between 0 and 8191 - The input frequency Fref3_ck shall be between 1 and 16 MHz In order to change the FRACV value on-the-fly even if the PLL is enabled, the application has to proceed as follow: - set the bit FRACLE to '0', - write the new fractional value into FRACV, - set the bit FRACLE to '1'.
    $10 constant RCC_FRACLE                     \ [0x10] PLL3 fractional latch enable Set and reset by software to latch the content of FRACV into the Sigma-Delta modulator. In order to latch the FRACV value into the Sigma-Delta modulator, FRACLE must be set to '0', then set to '1': the transition 0 to '1' transfers the content of FRACV into the modulator. Refer to and for additional information on the PLL programming.
  [then]


  [ifdef] RCC_RCC_PLL3CSGR_DEF
    \
    \ @brief RCC PLL3 clock spreading generator register
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MOD_PER                    \ [0x00 : 13] Modulation Period Adjustment for PLL3 Written by software to adjust the modulation period of the clock spreading generator.
    $0d constant RCC_TPDFN_DIS                  \ [0x0d] Dithering TPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
    $0e constant RCC_RPDFN_DIS                  \ [0x0e] Dithering RPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
    $0f constant RCC_SSCG_MODE                  \ [0x0f] Spread spectrum clock generator mode Set and reset by software to select the clock spreading mode.
    $10 constant RCC_INC_STEP                   \ [0x10 : 15] Modulation Depth Adjustment for PLL3 Written by software to adjust the modulation depth of the clock spreading generator.
  [then]


  [ifdef] RCC_RCC_PLL4CR_DEF
    \
    \ @brief RCC PLL4 control register
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLLON                      \ [0x00] PLL4 enable
    $01 constant RCC_PLL4RDY                    \ [0x01] PLL4 clock ready flag Set by hardware to indicate that the PLL4 is locked.
    $02 constant RCC_SSCG_CTRL                  \ [0x02] Clock Spreading Generator of PLL4 enable Set and reset by software to enable the clock spreading generator of PLL4, in order to reduce the amount of EMI peaks.
    $04 constant RCC_DIVPEN                     \ [0x04] PLL4 DIVP divider output enable Set and reset by software to enable the pll4_p_ck output of the PLL4. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll4_p_ck is not needed, DIVPEN must be set to '0'.
    $05 constant RCC_DIVQEN                     \ [0x05] PLL4 DIVQ divider output enable Set and reset by software to enable the pll4_q_ck output of the PLL4. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll4_q_ck is not needed, DIVQEN must be set to '0'.
    $06 constant RCC_DIVREN                     \ [0x06] PLL4 DIVR divider output enable Set and reset by software to enable the pll4_r_ck output of the PLL4. Cleared by hardware when entering a Stop mode or Standby. In order to save power, when the pll4_r_ck is not needed, DIVREN must be set to '0'.
  [then]


  [ifdef] RCC_RCC_PLL4CFGR1_DEF
    \
    \ @brief RCC PLL4 configuration register 1
    \ Address offset: 0x524
    \ Reset value: 0x00010031
    \
    $00 constant RCC_DIVN                       \ [0x00 : 9] Multiplication factor for PLL4 VCO Written by software to control the multiplication factor of the VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is between 400 and 800 MHz. VCO output frequency = Fref4_ck x (DIVN+1), when value 0 has been loaded into FRACV, with: - Valid division ratios for DIVN: between 25 and 200 - The input frequency Fref4_ck between 4 and 16 MHz ... ... Others: wrong configurations
    $10 constant RCC_DIVM4                      \ [0x10 : 6] Prescaler for PLL4 Set and cleared by software to configure the prescaler of the PLL4. ...
    $18 constant RCC_IFRGE                      \ [0x18 : 2] PLL4 input frequency range Written by software to select the proper reference frequency range used for PLL4. x0: The PLL4 input (ref4_ck) clock range frequency is between 4 and 8 MHz (default after reset) x1: The PLL4 input (ref4_ck) clock range frequency is between 8 and 16 MHz Note that if ref3_ck is equal to 8Â MHz, it is recommended to set IFRGE = 'x1â
  [then]


  [ifdef] RCC_RCC_PLL4CFGR2_DEF
    \
    \ @brief RCC PLL4 configuration register 2
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DIVP                       \ [0x00 : 7] PLL4 DIVP division factor Written by software to control the frequency of the pll4_p_ck clock. ...
    $08 constant RCC_DIVQ                       \ [0x08 : 7] PLL4 DIVQ division factor Written by software to control the frequency of the pll4_q_ck clock. ...
    $10 constant RCC_DIVR                       \ [0x10 : 7] PLL4 DIVR division factor Written by software to control the frequency of the pll4_r_ck clock. ...
  [then]


  [ifdef] RCC_RCC_PLL4FRACR_DEF
    \
    \ @brief RCC PLL4 fractional register
    \ Address offset: 0x52C
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACV                      \ [0x03 : 13] Fractional part of the multiplication factor for PLL4 VCO Written by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL4 VCO. Warning: the software has to set correctly these bits to ensure that the VCO output frequency is between its valid frequency range, which is between 400 and 800 MHz. VCO output frequency = Fref4_ck x ((DIVN+1) + (FRACV / 8192)), with - DIVN shall be between 4 and 512 - FRACV can be between 0 and 8191 - The input frequency Fref4_ck shall be between 1 and 16 MHz In order to change the FRACV value on-the-fly even if the PLL is enabled, the application has to proceed as follow: - set the bit FRACLE to '0', - write the new fractional value into FRACV, - set the bit FRACLE to '1'.
    $10 constant RCC_FRACLE                     \ [0x10] PLL4 fractional latch enable Set and reset by software to latch the content of FRACV into the Sigma-Delta modulator. In order to latch the FRACV value into the Sigma-Delta modulator, FRACLE must be set to '0', then set to '1': the transition 0 to '1' transfers the content of FRACV into the modulator. Refer to Section: Refer to and dividers for additional information.
  [then]


  [ifdef] RCC_RCC_PLL4CSGR_DEF
    \
    \ @brief RCC PLL4 clock spreading generator register
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MOD_PER                    \ [0x00 : 13] Modulation Period Adjustment for PLL4 Written by software to adjust the modulation period of the clock spreading generator.
    $0d constant RCC_TPDFN_DIS                  \ [0x0d] Dithering TPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
    $0e constant RCC_RPDFN_DIS                  \ [0x0e] Dithering RPDF noise control Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
    $0f constant RCC_SSCG_MODE                  \ [0x0f] Spread spectrum clock generator mode Set and reset by software to select the clock spreading mode.
    $10 constant RCC_INC_STEP                   \ [0x10 : 15] Modulation Depth Adjustment for PLL4 Written by software to adjust the modulation depth of the clock spreading generator.
  [then]


  [ifdef] RCC_RCC_MPCKSELR_DEF
    \
    \ @brief RCC MPU clock selection register
    \ Address offset: 0x540
    \ Reset value: 0x80000000
    \
    $00 constant RCC_MPUSRC                     \ [0x00 : 2] MPU clock switch Written by software to select the MPU sub-system clock source (mpuss_ck). Note that MPUDIV is disabled if MPUSRC[1:0] is different from '11'. Be sure that MPUDIV is different from '000' before setting MPUSRC to '11'.
    $1f constant RCC_MPUSRCRDY                  \ [0x1f] MPU clock switch status Set and reset by hardware to indicate if the MPU clock switch transition has been properly performed.
  [then]


  [ifdef] RCC_RCC_ASSCKSELR_DEF
    \
    \ @brief RCC AXI sub-system clock selection register.
    \ Address offset: 0x544
    \ Reset value: 0x80000000
    \
    $00 constant RCC_AXISSRC                    \ [0x00 : 3] AXI sub-system clock switch Written by software to select the AXI sub-system clock source (axiss_ck). others: axiss_ck is gated
    $1f constant RCC_AXISSRCRDY                 \ [0x1f] AXI sub-system clock switch status Set and reset by hardware to indicate if the AXI clock switch transition has been properly performed.
  [then]


  [ifdef] RCC_RCC_MSSCKSELR_DEF
    \
    \ @brief RCC MLAHB sub-system clock selection register
    \ Address offset: 0x548
    \ Reset value: 0x80000000
    \
    $00 constant RCC_MLAHBSSRC                  \ [0x00 : 2] MLAHB sub-system clock switch Written by software to select the MLAHB sub-system clock source (mlahbss_ck). Reset by hardware in order to select hsi_ck when the system exits from one of the Stop modes.
    $1f constant RCC_MLAHBSSRCRDY               \ [0x1f] MLAHB sub-system clock switch status Set and reset by hardware to indicate if the MLAHB clock switch transition has been properly performed.
  [then]


  [ifdef] RCC_RCC_CPERCKSELR_DEF
    \
    \ @brief RCC common peripheral kernel clock selection register
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_CKPERSRC                   \ [0x00 : 2] Oscillator selection for kernel clock Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_RTCDIVR_DEF
    \
    \ @brief RCC RTC clock division register
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RTCDIV                     \ [0x00 : 6] HSE division factor for RTC clock Set and cleared by software to divide the HSE to generate a clock for RTC. Caution: The software has to set these bits correctly to ensure that the clock supplied to the RTC is lower than 4 MHz. These bits must be configured if needed before selecting the RTC clock source. Note that when the RTCSRC is different from 3, this divider is disabled (does not provide clock). ...
  [then]


  [ifdef] RCC_RCC_MPCKDIVR_DEF
    \
    \ @brief RCC MPU clock divider register
    \ Address offset: 0x564
    \ Reset value: 0x80000001
    \
    $00 constant RCC_MPUDIV                     \ [0x00 : 4] MPU Core clock divider Written by software to control the MPU clock division factor when the MPUSRC is set to position 3. It is possible to change this division ratio on-the-fly. It impacts only the frequency of the MPU clock. The clocks are divided with the new prescaler factor, from 1 to 16 pll1_p_ck cycles after MPUDIV update. The application can check if the new division factor is taken into account by reading back the MPUDIVRDY flag. Note that this divider is disabled if MPUSRC[1:0] is different from '11'. 0x<n>: The mpuss_ck is equal to pll1_p_ck divided by 0x<n>+1
    $1f constant RCC_MPUDIVRDY                  \ [0x1f] MPU sub-system clock divider status Set and reset by hardware to indicate if the new division factor is taken into account. This bit significant only when MPUSRC[1:0] = '11'.
  [then]


  [ifdef] RCC_RCC_AXIDIVR_DEF
    \
    \ @brief RCC AXI clock divider register
    \ Address offset: 0x568
    \ Reset value: 0x80000000
    \
    $00 constant RCC_AXIDIV                     \ [0x00 : 3] AXI, AHB5 and AHB6 clock divider Written by software to control the AXI, AHB5 and AHB6 clock division factor. It is possible to change this division ratio on-the-fly. It impacts the frequency of AXI, APB4, APB5 AHB5 and AHB6 clocks. The clocks are divided with the new prescaler factor, from 1 to 4 axiss_ck cycles after AXIDIV update. The application can check if the new division factor is taken into account by reading back the AXIDIVRDY flag. others: axiss_ck / 4
    $1f constant RCC_AXIDIVRDY                  \ [0x1f] AXI sub-system clock divider status Set and reset by hardware to indicate if the new division factor is taken into account.
  [then]


  [ifdef] RCC_RCC_MLAHBDIVR_DEF
    \
    \ @brief RCC MLAHB clock divider register
    \ Address offset: 0x56C
    \ Reset value: 0x80000000
    \
    $00 constant RCC_MLAHBDIV                   \ [0x00 : 4] MLAHB clock divider Written by software to control the MLAHB clock division factor. Changing this division ratio has an impact on the frequency of MLAHB clock, and all bus matrix clocks. The clocks are divided with the new prescaler factor, from 1 to 512 cycles of mlahbss_ck, after MLAHBDIV update. The application can check if the new division factor is taken into account by reading back the MLAHBDIVRDY flag. others: mlahbss_ck divided by 512
    $1f constant RCC_MLAHBDIVRDY                \ [0x1f] MLAHB clock prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.
  [then]


  [ifdef] RCC_RCC_APB1DIVR_DEF
    \
    \ @brief RCC APB1 clock divider register
    \ Address offset: 0x570
    \ Reset value: 0x80000000
    \
    $00 constant RCC_APB1DIV                    \ [0x00 : 3] APB1 clock divider Written by software to control the APB1 clock division factor. The APB1 peripheral clock is divided with the new prescaler factor, from 1 to 16 mlhclk cycles after APB1DIV update. The application can check if the new division factor is taken into account by reading back the APB1DIVRDY flag. others: Not allowed
    $1f constant RCC_APB1DIVRDY                 \ [0x1f] APB1 clock prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.
  [then]


  [ifdef] RCC_RCC_APB2DIVR_DEF
    \
    \ @brief RCC APB2 clock divider register
    \ Address offset: 0x574
    \ Reset value: 0x80000000
    \
    $00 constant RCC_APB2DIV                    \ [0x00 : 3] APB2 clock divider Written by software to control the APB2 clock division factor. The APB2 clock is divided with the new prescaler factor, from 1 to 16 mlhclk cycles after APB2DIV update. The application can check if the new division factor is taken into account by reading back the APB2DIVRDY flag. others: Not allowed
    $1f constant RCC_APB2DIVRDY                 \ [0x1f] APB2 clock prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.
  [then]


  [ifdef] RCC_RCC_APB3DIVR_DEF
    \
    \ @brief RCC APB3 clock divider register
    \ Address offset: 0x578
    \ Reset value: 0x80000000
    \
    $00 constant RCC_APB3DIV                    \ [0x00 : 3] APB3 clock divider Written by software to control the APB3 clock division factor. The APB3 clock is divided by this new prescaler factor, from 1 to 16 hclk cycles after APB3DIV update. The application can check if the new division factor is taken into account by reading back the APB3DIVRDY flag. others: hclk / 16
    $1f constant RCC_APB3DIVRDY                 \ [0x1f] APB3 clock prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.
  [then]


  [ifdef] RCC_RCC_APB4DIVR_DEF
    \
    \ @brief RCC APB4 clock divider register.
    \ Address offset: 0x57C
    \ Reset value: 0x80000000
    \
    $00 constant RCC_APB4DIV                    \ [0x00 : 3] APB4 clock divider Written by software to control the APB4 clock division factor. It is possible to change this division ratio on-the-fly. It impacts only the frequency of APB4 clock. The clocks are divided with the new prescaler factor, from 1 to 16 aclk cycles after APB4DIV update. The application can check if the new division factor is taken into account by reading back the APB4DIVRDY flag. others: aclk / 16
    $1f constant RCC_APB4DIVRDY                 \ [0x1f] APB4 clock divider status Set and reset by hardware to indicate if the new division factor is taken into account.
  [then]


  [ifdef] RCC_RCC_APB5DIVR_DEF
    \
    \ @brief RCC APB5 clock divider register
    \ Address offset: 0x580
    \ Reset value: 0x80000000
    \
    $00 constant RCC_APB5DIV                    \ [0x00 : 3] APB5 clock divider Written by software to control the APB5 clock division factor. It is possible to change this division ratio on-the-fly. It impacts only the frequency of APB5 clock. The clocks are divided with the new prescaler factor, from 1 to 16 aclk cycles after APB5DIV update. The application can check if the new division factor is taken into account by reading the APB5DIVRDY flag. others: aclk / 16
    $1f constant RCC_APB5DIVRDY                 \ [0x1f] APB5 clock divider status Set and reset by hardware to indicate if the new division factor is taken into account.
  [then]


  [ifdef] RCC_RCC_APB6DIVR_DEF
    \
    \ @brief RCC APB6 clock divider register
    \ Address offset: 0x584
    \ Reset value: 0x80000000
    \
    $00 constant RCC_APB6DIV                    \ [0x00 : 3] APB6 clock divider Written by software to control the APB6 clock division factor. It is possible to change this division ratio on-the-fly. It impacts only the frequency of APB6 clock. The clocks are divided with the new prescaler factor, from 1 to 16 aclk cycles after APB6DIV update. The application can check if the new division factor is taken into account by reading the APB6DIVRDY flag. others: aclk / 16
    $1f constant RCC_APB6DIVRDY                 \ [0x1f] APB6 clock divider status Set and reset by hardware to indicate if the new division factor is taken into account.
  [then]


  [ifdef] RCC_RCC_TIMG1PRER_DEF
    \
    \ @brief RCC APB1 timers group1 prescaler register.
    \ Address offset: 0x5A0
    \ Reset value: 0x80000000
    \
    $00 constant RCC_TIMG1PRE                   \ [0x00] Timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB1 domain. Refer to .
    $1f constant RCC_TIMG1PRERDY                \ [0x1f] Timers clocks prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.
  [then]


  [ifdef] RCC_RCC_TIMG2PRER_DEF
    \
    \ @brief RCC APB2 timers group2 prescaler register
    \ Address offset: 0x5A4
    \ Reset value: 0x80000000
    \
    $00 constant RCC_TIMG2PRE                   \ [0x00] Timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB2 domain. Refer to .
    $1f constant RCC_TIMG2PRERDY                \ [0x1f] Timers clocks prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.
  [then]


  [ifdef] RCC_RCC_TIMG3PRER_DEF
    \
    \ @brief RCC APB6 timers group3 prescaler register
    \ Address offset: 0x5A8
    \ Reset value: 0x80000000
    \
    $00 constant RCC_TIMG3PRE                   \ [0x00] Timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB6 domain. Refer to .
    $1f constant RCC_TIMG3PRERDY                \ [0x1f] Timers clocks prescaler status Set and reset by hardware to indicate if the new division factor is taken into account.
  [then]


  [ifdef] RCC_RCC_DDRITFCR_DEF
    \
    \ @brief RCC DDR interface control register
    \ Address offset: 0x5C0
    \ Reset value: 0x000FD022
    \
    $00 constant RCC_DDRC1EN                    \ [0x00] DDRC port 1 peripheral clocks enable If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of ddrc_ker_ckg, aclk1_ddrc and pclk4_ddrc clocks.
    $01 constant RCC_DDRC1LPEN                  \ [0x01] DDRC port 1 peripheral clocks enable during CSleep mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of ddrc_ker_ckg, aclk1_ddrc and pclk4_ddrc in CSleep.
    $04 constant RCC_DDRPHYCEN                  \ [0x04] DDRPHYC peripheral clocks enable If DDRPHYC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of dphy_ker_ck and pclk4_dphy
    $05 constant RCC_DDRPHYCLPEN                \ [0x05] DDRPHYC peripheral clocks enable during CSleep mode If DDRPHYC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of dphy_ker_ck and pclk4_dphy in CSleep
    $06 constant RCC_DDRCAPBEN                  \ [0x06] DDRC APB clock enable If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of pclk4_ddrc clock.
    $07 constant RCC_DDRCAPBLPEN                \ [0x07] DDRC APB clock enable during CSleep mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of pclk4_ddrc clock during CSleep mode.
    $08 constant RCC_AXIDCGEN                   \ [0x08] AXIDCG enable during MPU CRun mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. When the dynamic clock gating is disabled, the clock is always provided to the DDRC if provided by the RCC.
    $09 constant RCC_DDRPHYCAPBEN               \ [0x09] DDRPHYC APB clock enable If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of pclk4_dphy clock.
    $0a constant RCC_DDRPHYCAPBLPEN             \ [0x0a] DDRPHYC APB clock enable during CSleep mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This bit is controlling the gating of pclk4_dphy clock during CSleep mode.
    $0b constant RCC_KERDCG_DLY                 \ [0x0b : 3] AXIDCG delay If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. It represents the delay between the falling edge of the cactive_ddrc signal and the moment where the KERDCG will gate the ddrc_ker_ckg. ...
    $0e constant RCC_DDRCAPBRST                 \ [0x0e] DDRC APB interface reset If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
    $0f constant RCC_DDRCAXIRST                 \ [0x0f] DDRC AXI interface reset If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
    $10 constant RCC_DDRCORERST                 \ [0x10] DDRC core reset If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
    $11 constant RCC_DPHYAPBRST                 \ [0x11] DDRPHYC APB interface reset If DDRPHYC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
    $12 constant RCC_DPHYRST                    \ [0x12] DDRPHYC reset If DDRPHYC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
    $13 constant RCC_DPHYCTLRST                 \ [0x13] DDRPHYC Control reset If DDRPHYC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
    $14 constant RCC_DDRCKMOD                   \ [0x14 : 3] RCC mode for DDR clock control If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. This mode can be used when the application wants to maintain a clock to the DLLs in order to avoid the re-lock sequences. In this mode it is recommended to have DDRCxEN = DDRCxLPEN = DDRPHYCEN = DDRPHYCLPEN = '1'. This mode can be used when the DLLs are in bypass. In this mode it is recommended to have DDRCxEN = DDRCxLPEN = DDRPHYCEN = DDRPHYCLPEN = '1'. This mode can be used when the application wants to maintain a clock to the DLLs. In this mode it is recommended to have DDRCxEN = DDRCxLPEN = DDRPHYCEN = DDRPHYCLPEN = '1'. This mode can be used when the DLLs are in bypass. In this mode it is recommended to have DDRCxEN = DDRCxLPEN = DDRPHYCEN = DDRPHYCLPEN = '1'. other: reserved
    $17 constant RCC_GSKPMOD                    \ [0x17] Glitch Skipper (GSKP) Mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software.
    $18 constant RCC_GSKPCTRL                   \ [0x18] Glitch skipper (GSKP) control If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set and clear by software. This has effect only if GSKPMOD = '0'.
    $19 constant RCC_DFILP_WIDTH                \ [0x19 : 3] Minimum duration of low-power request command If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. The low power request duration must always be bigger or equal to 1 microsecond. If this duration is not respected, the DDR interface behavior is not guaranteed. The application has to program properly DFILP_WIDTH in order to ensure a delay bigger or equal to 1 microsecond. Note that the delay is also dependent of the frequency of the dphy_ker_ck clock. Others: Forces a delay of 544 x Tdphy_ker_ck to be used when Fdphy_ker_ck is between 410 and 533MHz
    $1c constant RCC_GSKP_DUR                   \ [0x1c : 4] Glitch skipper duration in automatic mode If DDRC block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. This field allow the application to define the amount of time where the glitch skipper is providing the clock dphy_ker_ck instead of the clock ddrc_ker_ck to the DDRC block. This feature is only working when the glitch skipper is set in automatic mode (GSKPMOD = '1'). This delay is equal to (GSKP_DUR + 1) x 32 x Tdphy_ker_ck ...
  [then]


  [ifdef] RCC_RCC_I2C12CKSELR_DEF
    \
    \ @brief RCC I2C1 and I2C2 kernel clock selection register
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant RCC_I2C12SRC                   \ [0x00 : 3] I2C1 and I2C2 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_I2C345CKSELR_DEF
    \
    \ @brief RCC I2C3, I2C4 and I2C5 kernel clock selection register.
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant RCC_I2C3SRC                    \ [0x00 : 3] I2C3 kernel clock source selection If I2C3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
    $03 constant RCC_I2C4SRC                    \ [0x03 : 3] I2C4 kernel clock source selection If I2C4 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
    $06 constant RCC_I2C5SRC                    \ [0x06 : 3] I2C5 kernel clock source selection If I2C5 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_SPI2S1CKSELR_DEF
    \
    \ @brief RCC SPI/I2S1 kernel clock selection register
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI1SRC                    \ [0x00 : 3] SPI/I2S1 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_SPI2S23CKSELR_DEF
    \
    \ @brief RCC SPI/I2S2 and SPI/I2S3 kernel clock selection register
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI23SRC                   \ [0x00 : 3] SPI/I2S2 and SPI/I2S3 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_SPI45CKSELR_DEF
    \
    \ @brief RCC SPI/I2S4 and SPI5 kernel clock selection register
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI4SRC                    \ [0x00 : 3] SPI/I2S4 kernel clock source selection If SPI/I2S4 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
    $03 constant RCC_SPI5SRC                    \ [0x03 : 3] SPI5 kernel clock source selection If SPI5 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_UART12CKSELR_DEF
    \
    \ @brief RCC USART1 and USART2 kernel clock selection register
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART1SRC                   \ [0x00 : 3] USART1 kernel clock source selection If USART1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
    $03 constant RCC_UART2SRC                   \ [0x03 : 3] USART2 kernel clock source selection If USART2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_UART35CKSELR_DEF
    \
    \ @brief RCC USART3 and UART5 kernel clock selection register
    \ Address offset: 0x618
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART35SRC                  \ [0x00 : 3] USART3 and UART5 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_UART4CKSELR_DEF
    \
    \ @brief RCC UART4 kernel clock selection register
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART4SRC                   \ [0x00 : 3] UART4 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_UART6CKSELR_DEF
    \
    \ @brief RCC USART6 kernel clock selection register
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART6SRC                   \ [0x00 : 3] USART6 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_UART78CKSELR_DEF
    \
    \ @brief RCC UART7 and UART8 kernel clock selection register
    \ Address offset: 0x624
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART78SRC                  \ [0x00 : 3] UART7 and UART8 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_LPTIM1CKSELR_DEF
    \
    \ @brief RCC LPTIM1 kernel clock selection register
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM1SRC                  \ [0x00 : 3] LPTIM1 kernel clock source selection Written by software. others: the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_LPTIM23CKSELR_DEF
    \
    \ @brief RCC LPTIM2 and LPTIM3 kernel clock selection register
    \ Address offset: 0x62C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM2SRC                  \ [0x00 : 3] LPTIM2 kernel clock source selection If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled
    $03 constant RCC_LPTIM3SRC                  \ [0x03 : 3] LPTIM3 kernel clock source selection If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_LPTIM45CKSELR_DEF
    \
    \ @brief RCC LPTIM4 and LPTIM5 kernel clock selection register
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM45SRC                 \ [0x00 : 3] LPTIM4 and LPTIM5 kernel clock source selection Written by software. others: the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_SAI1CKSELR_DEF
    \
    \ @brief RCC SAI1 kernel clock selection register
    \ Address offset: 0x634
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SAI1SRC                    \ [0x00 : 3] SAI1 and DFSDM kernel clock source selection Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_SAI2CKSELR_DEF
    \
    \ @brief RCC SAI2 kernel clock selection register
    \ Address offset: 0x638
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SAI2SRC                    \ [0x00 : 3] SAI2 kernel clock source selection Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_FDCANCKSELR_DEF
    \
    \ @brief RCC FDCAN kernel clock selection register
    \ Address offset: 0x63C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FDCANSRC                   \ [0x00 : 2] FDCAN kernel clock source selection Written by software.
  [then]


  [ifdef] RCC_RCC_SPDIFCKSELR_DEF
    \
    \ @brief RCC SPDIFRX kernel clock selection register
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPDIFSRC                   \ [0x00 : 2] SPDIFRX kernel clock source selection Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_ADC12CKSELR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the (AHB2) ADC1 and ADC2 blocks. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
    \ Address offset: 0x644
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ADC1SRC                    \ [0x00 : 2] ADC1 kernel clock source selection If ADC1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled
    $02 constant RCC_ADC2SRC                    \ [0x02 : 2] ADC2 kernel clock source selection If ADC2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_SDMMC12CKSELR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the (AHB6) SDMMC1 and SDMMC2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
    \ Address offset: 0x648
    \ Reset value: 0x00000003
    \
    $00 constant RCC_SDMMC1SRC                  \ [0x00 : 3] SDMMC1 kernel clock source selection If SDMMC1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
    $03 constant RCC_SDMMC2SRC                  \ [0x03 : 3] SDMMC2 kernel clock source selection If SDMMC2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_ETH12CKSELR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the ETH1 and ETH2 blocks. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ETH1SRC                    \ [0x00 : 2] ETH1 kernel clock source selection If ETH1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled
    $04 constant RCC_ETH1PTPDIV                 \ [0x04 : 4] ETH1 clock divider for Precision Time Protocol (PTP) If ETH1 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software to configure the divider value. ...
    $08 constant RCC_ETH2SRC                    \ [0x08 : 2] ETH2 kernel clock source selection If ETH2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. others: the kernel clock is disabled
    $0c constant RCC_ETH2PTPDIV                 \ [0x0c : 4] ETH2 clock divider for Precision Time Protocol (PTP) If ETH2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software to configure the divider value. ...
  [then]


  [ifdef] RCC_RCC_USBCKSELR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the USBPHY PLL of the USB Host (USBH) and the USB On-The-Go (USBO). It also controls the pre-divider for the reference clock for the USBPHY. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USBPHYSRC                  \ [0x00 : 2] USB PHY kernel clock source selection If USBPHY block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software. other: clock disabled
    $04 constant RCC_USBOSRC                    \ [0x04] USB OTG kernel clock source selection If USBO block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Written by software.
  [then]


  [ifdef] RCC_RCC_QSPICKSELR_DEF
    \
    \ @brief If (AHB6) QUADSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the QUADSPI. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant RCC_QSPISRC                    \ [0x00 : 2] QUADSPI kernel clock source selection Written by software.
  [then]


  [ifdef] RCC_RCC_FMCCKSELR_DEF
    \
    \ @brief If (AHB6) FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the FMC block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
    \ Address offset: 0x658
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FMCSRC                     \ [0x00 : 2] FMC kernel clock source selection Written by software.
  [then]


  [ifdef] RCC_RCC_RNG1CKSELR_DEF
    \
    \ @brief If (AHB5) RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the RNG1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNG1SRC                    \ [0x00 : 2] RNG1 kernel clock source selection Written by software.
  [then]


  [ifdef] RCC_RCC_STGENCKSELR_DEF
    \
    \ @brief If (APB5) STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. STGEN is a dual APB interface IP, with STGENC APB5 controller part which may be secure or non-secure depending on the corresponding DECPROT[1]. Its other STGENRO APB4 read-only interface is non-secure. This register is used to select the peripheral clock for the STGEN block. Note that this clock is used to provide a time reference for the application. Refer to SectionÂ : Clock enabling delays.
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant RCC_STGENSRC                   \ [0x00 : 2] Oscillator selection for kernel clock Set and cleared by software. others: Clock disabled
  [then]


  [ifdef] RCC_RCC_DCMIPPCKSELR_DEF
    \
    \ @brief If (APB4) DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the DCMIPP block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DCMIPPSRC                  \ [0x00 : 2] DCMIPP kernel clock source selection Written by software.
  [then]


  [ifdef] RCC_RCC_SAESCKSELR_DEF
    \
    \ @brief If (AHB5) SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the SAES block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SAESSRC                    \ [0x00 : 2] SAES kernel clock source selection Written by software.
  [then]


  [ifdef] RCC_RCC_APB1RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 block reset Set by software.
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 block reset Set by software.
    $02 constant RCC_TIM4RST                    \ [0x02] TIM4 block reset Set by software.
    $03 constant RCC_TIM5RST                    \ [0x03] TIM5 block reset Set by software.
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 block reset Set by software.
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 block reset Set by software.
    $09 constant RCC_LPTIM1RST                  \ [0x09] LPTIM1 block reset Set by software.
    $0b constant RCC_SPI2RST                    \ [0x0b] SPI/I2S2 block reset Set by software.
    $0c constant RCC_SPI3RST                    \ [0x0c] SPI3 block reset Set by software.
    $0f constant RCC_USART3RST                  \ [0x0f] USART3 block reset Set by software.
    $10 constant RCC_UART4RST                   \ [0x10] UART4 block reset Set by software.
    $11 constant RCC_UART5RST                   \ [0x11] UART5 block reset Set by software.
    $12 constant RCC_UART7RST                   \ [0x12] UART7 block reset Set by software.
    $13 constant RCC_UART8RST                   \ [0x13] UART8 block reset Set by software.
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 block reset Set by software.
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 block reset Set by software.
    $1a constant RCC_SPDIFRST                   \ [0x1a] SPDIFRX block reset Set by software.
  [then]


  [ifdef] RCC_RCC_APB1RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 block reset Cleared by software.
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 block reset Cleared by software.
    $02 constant RCC_TIM4RST                    \ [0x02] TIM4 block reset Cleared by software.
    $03 constant RCC_TIM5RST                    \ [0x03] TIM5 block reset Cleared by software.
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 block reset Cleared by software.
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 block reset Cleared by software.
    $09 constant RCC_LPTIM1RST                  \ [0x09] LPTIM1 block reset Cleared by software.
    $0b constant RCC_SPI2RST                    \ [0x0b] SPI2 block reset Cleared by software.
    $0c constant RCC_SPI3RST                    \ [0x0c] SPI3 block reset Cleared by software.
    $0f constant RCC_USART3RST                  \ [0x0f] USART3 block reset Cleared by software.
    $10 constant RCC_UART4RST                   \ [0x10] UART4 block reset Cleared by software.
    $11 constant RCC_UART5RST                   \ [0x11] UART5 block reset Cleared by software.
    $12 constant RCC_UART7RST                   \ [0x12] UART7 block reset Cleared by software.
    $13 constant RCC_UART8RST                   \ [0x13] UART8 block reset Cleared by software.
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 block reset Cleared by software.
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 block reset Cleared by software.
    $1a constant RCC_SPDIFRST                   \ [0x1a] SPDIFRX block reset Cleared by software.
  [then]


  [ifdef] RCC_RCC_APB2RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RST                    \ [0x00] TIM1 block reset Set by software.
    $01 constant RCC_TIM8RST                    \ [0x01] TIM8 block reset Set by software.
    $08 constant RCC_SPI1RST                    \ [0x08] SPI/I2S1 block reset Set by software.
    $0d constant RCC_USART6RST                  \ [0x0d] USART6 block reset Set by software.
    $10 constant RCC_SAI1RST                    \ [0x10] SAI1 block reset Set by software.
    $11 constant RCC_SAI2RST                    \ [0x11] SAI2 block reset Set by software.
    $14 constant RCC_DFSDMRST                   \ [0x14] DFSDM block reset Set by software.
    $18 constant RCC_FDCANRST                   \ [0x18] FDCAN block reset Set by software.
  [then]


  [ifdef] RCC_RCC_APB2RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
    \ Address offset: 0x6AC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RST                    \ [0x00] TIM1 block reset Cleared by software.
    $01 constant RCC_TIM8RST                    \ [0x01] TIM8 block reset Cleared by software.
    $08 constant RCC_SPI1RST                    \ [0x08] SPI/I2S1 block reset Cleared by software.
    $0d constant RCC_USART6RST                  \ [0x0d] USART6 block reset Cleared by software.
    $10 constant RCC_SAI1RST                    \ [0x10] SAI1 block reset Cleared by software.
    $11 constant RCC_SAI2RST                    \ [0x11] SAI2 block reset Cleared by software.
    $14 constant RCC_DFSDMRST                   \ [0x14] DFSDM block reset Cleared by software.
    $18 constant RCC_FDCANRST                   \ [0x18] FDCAN block reset Cleared by software.
  [then]


  [ifdef] RCC_RCC_APB3RSTSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
    \ Address offset: 0x6B0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM2RST                  \ [0x00] LPTIM2 block reset Set by software. If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure.
    $01 constant RCC_LPTIM3RST                  \ [0x01] LPTIM3 block reset Set by software. If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure.
    $02 constant RCC_LPTIM4RST                  \ [0x02] LPTIM4 block reset Set by software.
    $03 constant RCC_LPTIM5RST                  \ [0x03] LPTIM5 block reset Set by software.
    $0b constant RCC_SYSCFGRST                  \ [0x0b] SYSCFG block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $0d constant RCC_VREFRST                    \ [0x0d] VREF block reset If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $10 constant RCC_DTSRST                     \ [0x10] DTS block reset Set by software.
    $11 constant RCC_PMBCTRLRST                 \ [0x11] PMBCTRL block reset (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT
  [then]


  [ifdef] RCC_RCC_APB3RSTCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
    \ Address offset: 0x6B4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM2RST                  \ [0x00] LPTIM2 block reset If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $01 constant RCC_LPTIM3RST                  \ [0x01] LPTIM3 block reset If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $02 constant RCC_LPTIM4RST                  \ [0x02] LPTIM4 block reset Cleared by software.
    $03 constant RCC_LPTIM5RST                  \ [0x03] LPTIM5 block reset Cleared by software.
    $0b constant RCC_SYSCFGRST                  \ [0x0b] SYSCFG block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $0d constant RCC_VREFRST                    \ [0x0d] VREF block reset If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $10 constant RCC_DTSRST                     \ [0x10] DTS block reset Cleared by software.
    $11 constant RCC_PMBCTRLRST                 \ [0x11] PMBCTRL block reset (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT
  [then]


  [ifdef] RCC_RCC_APB4RSTSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
    \ Address offset: 0x6B8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCRST                    \ [0x00] LTDC block reset If LTDC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $01 constant RCC_DCMIPPRST                  \ [0x01] DCMIPP block reset If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_DDRPERFMRST                \ [0x08] DDRPERFM block reset Set by software.
    $10 constant RCC_USBPHYRST                  \ [0x10] USBPHYC block reset If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_APB4RSTCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
    \ Address offset: 0x6BC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCRST                    \ [0x00] LTDC block reset If LTDC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $01 constant RCC_DCMIPPRST                  \ [0x01] DCMIPP block reset If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $08 constant RCC_DDRPERFMRST                \ [0x08] DDRPERFM block reset Cleared by software.
    $10 constant RCC_USBPHYRST                  \ [0x10] USBPHYC block reset If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
  [then]


  [ifdef] RCC_RCC_APB5RSTSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
    \ Address offset: 0x6C0
    \ Reset value: 0x00000000
    \
    $14 constant RCC_STGENRST                   \ [0x14] STGEN block reset If STGENC (STGEN controller sub-part) is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_APB5RSTCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
    \ Address offset: 0x6C4
    \ Reset value: 0x00000000
    \
    $14 constant RCC_STGENRST                   \ [0x14] STGEN block reset If STGENC (STGEN controller sub-part) is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
  [then]


  [ifdef] RCC_RCC_APB6RSTSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
    \ Address offset: 0x6C8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1RST                  \ [0x00] USART1 block reset If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $01 constant RCC_USART2RST                  \ [0x01] USART2 block reset If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $02 constant RCC_SPI4RST                    \ [0x02] SPI4 block reset If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $03 constant RCC_SPI5RST                    \ [0x03] SPI5 block reset If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $04 constant RCC_I2C3RST                    \ [0x04] I2C3 block reset If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $05 constant RCC_I2C4RST                    \ [0x05] I2C4 block reset If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $06 constant RCC_I2C5RST                    \ [0x06] I2C5 block reset If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $07 constant RCC_TIM12RST                   \ [0x07] TIM12 block reset If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_TIM13RST                   \ [0x08] TIM13 block reset If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $09 constant RCC_TIM14RST                   \ [0x09] TIM14 block reset If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0a constant RCC_TIM15RST                   \ [0x0a] TIM15 block reset If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0b constant RCC_TIM16RST                   \ [0x0b] TIM16 block reset If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0c constant RCC_TIM17RST                   \ [0x0c] TIM17 block reset If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_APB6RSTCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1RST                  \ [0x00] USART1 block reset If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $01 constant RCC_USART2RST                  \ [0x01] USART2 block reset If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $02 constant RCC_SPI4RST                    \ [0x02] SPI4 block reset If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $03 constant RCC_SPI5RST                    \ [0x03] SPI5 block reset If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $04 constant RCC_I2C3RST                    \ [0x04] I2C3 block reset If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $05 constant RCC_I2C4RST                    \ [0x05] I2C4 block reset If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $06 constant RCC_I2C5RST                    \ [0x06] I2C5 block reset If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $07 constant RCC_TIM12RST                   \ [0x07] TIM12 block reset If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_TIM13RST                   \ [0x08] TIM13 block reset If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $09 constant RCC_TIM14RST                   \ [0x09] TIM14 block reset If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0a constant RCC_TIM15RST                   \ [0x0a] TIM15 block reset If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0b constant RCC_TIM16RST                   \ [0x0b] TIM16 block reset If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0c constant RCC_TIM17RST                   \ [0x0c] TIM17 block reset If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_AHB2RSTSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1 block reset Set by software.
    $01 constant RCC_DMA2RST                    \ [0x01] DMA2 block reset Set by software.
    $02 constant RCC_DMAMUX1RST                 \ [0x02] DMAMUX1 block reset Set by software.
    $03 constant RCC_DMA3RST                    \ [0x03] DMA3 block reset If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $04 constant RCC_DMAMUX2RST                 \ [0x04] DMAMUX2 block reset If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $05 constant RCC_ADC1RST                    \ [0x05] ADC1 block reset If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $06 constant RCC_ADC2RST                    \ [0x06] ADC2 block reset If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_USBORST                    \ [0x08] USBO block reset If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_AHB2RSTCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
    \ Address offset: 0x6D4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1 block reset Cleared by software.
    $01 constant RCC_DMA2RST                    \ [0x01] DMA2 block reset Cleared by software.
    $02 constant RCC_DMAMUX1RST                 \ [0x02] DMAMUX1 block reset Cleared by software.
    $03 constant RCC_DMA3RST                    \ [0x03] DMA3 block reset If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $04 constant RCC_DMAMUX2RST                 \ [0x04] DMAMUX2 block reset If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $05 constant RCC_ADC1RST                    \ [0x05] ADC1 block reset If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $06 constant RCC_ADC2RST                    \ [0x06] ADC2 block reset If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $08 constant RCC_USBORST                    \ [0x08] USBO block reset If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB4RSTSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
    \ Address offset: 0x6E0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] GPIOA block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $01 constant RCC_GPIOBRST                   \ [0x01] GPIOB block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $02 constant RCC_GPIOCRST                   \ [0x02] GPIOC block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $03 constant RCC_GPIODRST                   \ [0x03] GPIOD block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $04 constant RCC_GPIOERST                   \ [0x04] GPIOE block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $05 constant RCC_GPIOFRST                   \ [0x05] GPIOF block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $06 constant RCC_GPIOGRST                   \ [0x06] GPIOG block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $07 constant RCC_GPIOHRST                   \ [0x07] GPIOH block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $08 constant RCC_GPIOIRST                   \ [0x08] GPIOI block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $0f constant RCC_TSCRST                     \ [0x0f] TSC block reset If TSC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_AHB4RSTCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] GPIOA block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $01 constant RCC_GPIOBRST                   \ [0x01] GPIOB block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $02 constant RCC_GPIOCRST                   \ [0x02] GPIOC block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $03 constant RCC_GPIODRST                   \ [0x03] GPIOD block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $04 constant RCC_GPIOERST                   \ [0x04] GPIOE block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $05 constant RCC_GPIOFRST                   \ [0x05] GPIOF block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $06 constant RCC_GPIOGRST                   \ [0x06] GPIOG block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $07 constant RCC_GPIOHRST                   \ [0x07] GPIOH block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $08 constant RCC_GPIOIRST                   \ [0x08] GPIOI block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $0f constant RCC_TSCRST                     \ [0x0f] TSC block reset If TSC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB5RSTSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
    \ Address offset: 0x6E8
    \ Reset value: 0x00000000
    \
    $02 constant RCC_PKARST                     \ [0x02] PKA block reset If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $03 constant RCC_SAESRST                    \ [0x03] SAES block reset If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $04 constant RCC_CRYP1RST                   \ [0x04] CRYP (3DES/AES) block reset If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $05 constant RCC_HASH1RST                   \ [0x05] HASH block reset If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $06 constant RCC_RNG1RST                    \ [0x06] RNG1 block reset If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $10 constant RCC_AXIMCRST                   \ [0x10] AXIMC block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
  [then]


  [ifdef] RCC_RCC_AHB5RSTCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
    \ Address offset: 0x6EC
    \ Reset value: 0x00000000
    \
    $02 constant RCC_PKARST                     \ [0x02] PKA block reset If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $03 constant RCC_SAESRST                    \ [0x03] SAES block reset If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $04 constant RCC_CRYP1RST                   \ [0x04] CRYP (3DES/AES) block reset If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $05 constant RCC_HASH1RST                   \ [0x05] HASH block reset If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $06 constant RCC_RNG1RST                    \ [0x06] RNG1 block reset If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $10 constant RCC_AXIMCRST                   \ [0x10] AXIMC block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
  [then]


  [ifdef] RCC_RCC_AHB6RSTSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
    \ Address offset: 0x6F0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMARST                    \ [0x00] MDMA block reset A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $01 constant RCC_MCERST                     \ [0x01] MCE block reset If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0a constant RCC_ETH1MACRST                 \ [0x0a] ETH1 MAC block reset If ETH1 MAC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0c constant RCC_FMCRST                     \ [0x0c] FMC block reset If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0e constant RCC_QSPIRST                    \ [0x0e] QUADSPI and the QUADSPI delay block reset If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $10 constant RCC_SDMMC1RST                  \ [0x10] SDMMC1 and the SDMMC1 delay (DLYBSD1) block reset If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $11 constant RCC_SDMMC2RST                  \ [0x11] SDMMC2 and the SDMMC2 delay (DLYBSD2) block reset If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $14 constant RCC_CRC1RST                    \ [0x14] CRC block reset Set by software.
    $18 constant RCC_USBHRST                    \ [0x18] USBH block reset Set by software.
    $1e constant RCC_ETH2MACRST                 \ [0x1e] ETH2 MAC block reset If ETH2 MAC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_AHB6RSTCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
    \ Address offset: 0x6F4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMARST                    \ [0x00] MDMA block reset A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $01 constant RCC_MCERST                     \ [0x01] MCE block reset If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0a constant RCC_ETH1MACRST                 \ [0x0a] ETH1 MAC block reset If ETH1 MAC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0c constant RCC_FMCRST                     \ [0x0c] FMC block reset If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0e constant RCC_QSPIRST                    \ [0x0e] QUADSPI and the QUADSPI delay block reset If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $10 constant RCC_SDMMC1RST                  \ [0x10] SDMMC1 and the SDMMC1 delay (DLYBSD1) block reset If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $11 constant RCC_SDMMC2RST                  \ [0x11] SDMMC2 and the SDMMC2 delay (DLYBSD2) block reset If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $14 constant RCC_CRC1RST                    \ [0x14] CRC block reset Cleared by software.
    $18 constant RCC_USBHRST                    \ [0x18] USBH block reset Cleared by software.
    $1e constant RCC_ETH2MACRST                 \ [0x1e] ETH2 MAC block reset If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_APB1ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective value of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x700
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 peripheral clocks enable Set by software.
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 peripheral clocks enable Set by software.
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4 peripheral clocks enable Set by software.
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5 peripheral clocks enable Set by software.
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 peripheral clocks enable Set by software.
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 peripheral clocks enable Set by software.
    $09 constant RCC_LPTIM1EN                   \ [0x09] LPTIM1 peripheral clocks enable Set by software.
    $0b constant RCC_SPI2EN                     \ [0x0b] SPI2 peripheral clocks enable Set by software.
    $0c constant RCC_SPI3EN                     \ [0x0c] SPI3 peripheral clocks enable Set by software.
    $0f constant RCC_USART3EN                   \ [0x0f] USART3 peripheral clocks enable Set by software.
    $10 constant RCC_UART4EN                    \ [0x10] UART4 peripheral clocks enable Set by software.
    $11 constant RCC_UART5EN                    \ [0x11] UART5 peripheral clocks enable Set by software.
    $12 constant RCC_UART7EN                    \ [0x12] UART7 peripheral clocks enable Set by software.
    $13 constant RCC_UART8EN                    \ [0x13] UART8 peripheral clocks enable Set by software.
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 peripheral clocks enable Set by software.
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 peripheral clocks enable Set by software.
    $1a constant RCC_SPDIFEN                    \ [0x1a] SPDIFRX peripheral clocks enable Set by software.
  [then]


  [ifdef] RCC_RCC_MP_APB1ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x704
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 peripheral clocks enable Cleared by software.
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 peripheral clocks enable Cleared by software.
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4 peripheral clocks enable Cleared by software.
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5 peripheral clocks enable Cleared by software.
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 peripheral clocks enable Cleared by software.
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 peripheral clocks enable Cleared by software.
    $09 constant RCC_LPTIM1EN                   \ [0x09] LPTIM1 peripheral clocks enable Cleared by software.
    $0b constant RCC_SPI2EN                     \ [0x0b] SPI2 peripheral clocks enable Cleared by software.
    $0c constant RCC_SPI3EN                     \ [0x0c] SPI3 peripheral clocks enable Cleared by software.
    $0f constant RCC_USART3EN                   \ [0x0f] USART3 peripheral clocks enable Cleared by software.
    $10 constant RCC_UART4EN                    \ [0x10] UART4 peripheral clocks enable Cleared by software.
    $11 constant RCC_UART5EN                    \ [0x11] UART5 peripheral clocks enable Cleared by software.
    $12 constant RCC_UART7EN                    \ [0x12] UART7 peripheral clocks enable Cleared by software.
    $13 constant RCC_UART8EN                    \ [0x13] UART8 peripheral clocks enable Cleared by software.
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 peripheral clocks enable Cleared by software.
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 peripheral clocks enable Cleared by software.
    $1a constant RCC_SPDIFEN                    \ [0x1a] SPDIFRX peripheral clocks enable Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_APB2ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x708
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1 peripheral clocks enable Set by software.
    $01 constant RCC_TIM8EN                     \ [0x01] TIM8 peripheral clocks enable Set by software.
    $08 constant RCC_SPI1EN                     \ [0x08] SPI/I2S1 peripheral clocks enable Set by software.
    $0d constant RCC_USART6EN                   \ [0x0d] USART6 peripheral clocks enable Set by software.
    $10 constant RCC_SAI1EN                     \ [0x10] SAI1 peripheral clocks enable Set by software.
    $11 constant RCC_SAI2EN                     \ [0x11] SAI2 peripheral clocks enable Set by software.
    $14 constant RCC_DFSDMEN                    \ [0x14] DFSDM peripheral clocks enable Set by software.
    $15 constant RCC_ADFSDMEN                   \ [0x15] Audio DFSDM peripheral clocks enable Set by software.
    $18 constant RCC_FDCANEN                    \ [0x18] FDCAN and CANRAM peripheral clocks enable Set by software.
  [then]


  [ifdef] RCC_RCC_MP_APB2ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to â0â.
    \ Address offset: 0x70C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1 peripheral clocks enable Cleared by software.
    $01 constant RCC_TIM8EN                     \ [0x01] TIM8 peripheral clocks enable Cleared by software.
    $08 constant RCC_SPI1EN                     \ [0x08] SPI/I2S1 peripheral clocks enable Cleared by software.
    $0d constant RCC_USART6EN                   \ [0x0d] USART6 peripheral clocks enable Cleared by software.
    $10 constant RCC_SAI1EN                     \ [0x10] SAI1 peripheral clocks enable Cleared by software.
    $11 constant RCC_SAI2EN                     \ [0x11] SAI2 peripheral clocks enable Cleared by software.
    $14 constant RCC_DFSDMEN                    \ [0x14] DFSDM peripheral clocks enable Cleared by software.
    $15 constant RCC_ADFSDMEN                   \ [0x15] Audio DFSDM peripheral clocks enable Cleared by software.
    $18 constant RCC_FDCANEN                    \ [0x18] FDCAN and CANRAM peripheral clocks enable Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_APB3ENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x710
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM2EN                   \ [0x00] LPTIM2 peripheral clocks enable If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $01 constant RCC_LPTIM3EN                   \ [0x01] LPTIM3 peripheral clocks enable If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $02 constant RCC_LPTIM4EN                   \ [0x02] LPTIM4 peripheral clocks enable Set by software.
    $03 constant RCC_LPTIM5EN                   \ [0x03] LPTIM5 peripheral clocks enable Set by software.
    $0d constant RCC_VREFEN                     \ [0x0d] VREF peripheral clocks enable If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $10 constant RCC_DTSEN                      \ [0x10] DTS peripheral clocks enable Set by software.
    $11 constant RCC_PMBCTRLEN                  \ [0x11] PMBCTRL peripheral clocks enable (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT
    $14 constant RCC_HDPEN                      \ [0x14] HDP peripheral clocks enable Set by software.
  [then]


  [ifdef] RCC_RCC_MP_APB3ENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x714
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM2EN                   \ [0x00] LPTIM2 peripheral clocks enable If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $01 constant RCC_LPTIM3EN                   \ [0x01] LPTIM3 peripheral clocks enable If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $02 constant RCC_LPTIM4EN                   \ [0x02] LPTIM4 peripheral clocks enable Cleared by software.
    $03 constant RCC_LPTIM5EN                   \ [0x03] LPTIM5 peripheral clocks enable Cleared by software.
    $0d constant RCC_VREFEN                     \ [0x0d] VREF peripheral clocks enable If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $10 constant RCC_DTSEN                      \ [0x10] DTS peripheral clocks enable Cleared by software.
    $11 constant RCC_PMBCTRLEN                  \ [0x11] PMBCTRL peripheral clocks enable (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT
    $14 constant RCC_HDPEN                      \ [0x14] HDP peripheral clocks enable Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_S_APB3ENSETR_DEF
    \
    \ @brief This is a secure register for enabling the clock of the SYSCFG.
    \ Address offset: 0x718
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] SYSCFG peripheral clocks enable Set by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_S_APB3ENCLRR_DEF
    \
    \ @brief This is a secure register for disabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x71C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] SYSCFG peripheral clocks enable Cleared by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_NS_APB3ENSETR_DEF
    \
    \ @brief This is a non-secure register, for enabling the clock of the SYSCFG.
    \ Address offset: 0x720
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] SYSCFG peripheral clocks enable Set by software.
  [then]


  [ifdef] RCC_RCC_MP_NS_APB3ENCLRR_DEF
    \
    \ @brief This is a non-secure register, for disabling the clock of the SYSCFG.
    \ Address offset: 0x724
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] SYSCFG peripheral clocks enable Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_APB4ENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x728
    \ Reset value: 0x00000000
    \
    $01 constant RCC_DCMIPPEN                   \ [0x01] DCMIPP peripheral clocks enable If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_DDRPERFMEN                 \ [0x08] DDRPERFM APB clock enable Set by software.
    $0f constant RCC_IWDG2APBEN                 \ [0x0f] IWDG2 APB clock enable Set by software.
    $10 constant RCC_USBPHYEN                   \ [0x10] USBPHYC peripheral clocks enable If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $14 constant RCC_STGENROEN                  \ [0x14] STGEN read-only interface peripheral clocks enable Set by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.
  [then]


  [ifdef] RCC_RCC_MP_APB4ENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x72C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_DCMIPPEN                   \ [0x01] DCMIPP peripheral clocks enable If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $08 constant RCC_DDRPERFMEN                 \ [0x08] DDRPERFM APB clock enable Cleared by software.
    $0f constant RCC_IWDG2APBEN                 \ [0x0f] IWDG2 APB clock enable Cleared by software.
    $10 constant RCC_USBPHYEN                   \ [0x10] USBPHYC peripheral clocks enable If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $14 constant RCC_STGENROEN                  \ [0x14] STGEN read-only interface peripheral clocks enable Cleared by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.
  [then]


  [ifdef] RCC_RCC_MP_S_APB4ENSETR_DEF
    \
    \ @brief This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x730
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCEN                     \ [0x00] LTDC peripheral clocks enable Set by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_S_APB4ENCLRR_DEF
    \
    \ @brief This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer.
    \ Address offset: 0x734
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCEN                     \ [0x00] LTDC peripheral clocks enable Cleared by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_NS_APB4ENSETR_DEF
    \
    \ @brief This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x738
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCEN                     \ [0x00] LTDC peripheral clocks enable Set by software.
  [then]


  [ifdef] RCC_RCC_MP_NS_APB4ENCLRR_DEF
    \
    \ @brief This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers.
    \ Address offset: 0x73C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCEN                     \ [0x00] LTDC peripheral clocks enable Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_APB5ENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x740
    \ Reset value: 0x00000000
    \
    $08 constant RCC_RTCAPBEN                   \ [0x08] RTC APB clock enable If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0b constant RCC_TZCEN                      \ [0x0b] TZC clocks enable Set by (secure) software. See for details.
    $0d constant RCC_ETZPCEN                    \ [0x0d] ETZPC peripheral clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $0f constant RCC_IWDG1APBEN                 \ [0x0f] IWDG1 APB clock enable If IWDG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $10 constant RCC_BSECEN                     \ [0x10] BSEC peripheral clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $14 constant RCC_STGENCEN                   \ [0x14] STGEN controller part, peripheral clocks enable If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.
  [then]


  [ifdef] RCC_RCC_MP_APB5ENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x744
    \ Reset value: 0x00000000
    \
    $08 constant RCC_RTCAPBEN                   \ [0x08] RTC APB clock enable If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0b constant RCC_TZCEN                      \ [0x0b] TZC clocks enable Cleared by (secure) software. See for details.
    $0d constant RCC_ETZPCEN                    \ [0x0d] ETZPC peripheral clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $0f constant RCC_IWDG1APBEN                 \ [0x0f] IWDG1 APB clock enable If IWDG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $10 constant RCC_BSECEN                     \ [0x10] BSEC peripheral clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $14 constant RCC_STGENCEN                   \ [0x14] STGEN controller part, peripheral clocks enable If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.
  [then]


  [ifdef] RCC_RCC_MP_APB6ENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x748
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1EN                   \ [0x00] USART1 peripherals clocks If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $01 constant RCC_USART2EN                   \ [0x01] USART2 peripherals clocks If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $02 constant RCC_SPI4EN                     \ [0x02] SPI4 peripherals clocks If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $03 constant RCC_SPI5EN                     \ [0x03] SPI5 peripherals clocks If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $04 constant RCC_I2C3EN                     \ [0x04] I2C3 peripherals clocks If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $05 constant RCC_I2C4EN                     \ [0x05] I2C4 peripherals clocks If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $06 constant RCC_I2C5EN                     \ [0x06] I2C5 peripherals clocks If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $07 constant RCC_TIM12EN                    \ [0x07] TIM12 peripherals clocks If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_TIM13EN                    \ [0x08] TIM13 peripherals clocks If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $09 constant RCC_TIM14EN                    \ [0x09] TIM14 peripherals clocks If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0a constant RCC_TIM15EN                    \ [0x0a] TIM15 peripherals clocks If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0b constant RCC_TIM16EN                    \ [0x0b] TIM16 peripherals clocks If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0c constant RCC_TIM17EN                    \ [0x0c] TIM17 peripherals clocks If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_MP_APB6ENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1EN                   \ [0x00] USART1 peripherals clocks If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $01 constant RCC_USART2EN                   \ [0x01] USART2 peripherals clocks If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $02 constant RCC_SPI4EN                     \ [0x02] SPI4 peripherals clocks If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $03 constant RCC_SPI5EN                     \ [0x03] SPI5 peripherals clocks If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $04 constant RCC_I2C3EN                     \ [0x04] I2C3 peripherals clocks If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $05 constant RCC_I2C4EN                     \ [0x05] I2C4 peripherals clocks If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $06 constant RCC_I2C5EN                     \ [0x06] I2C5 peripherals clocks If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $07 constant RCC_TIM12EN                    \ [0x07] TIM12 peripherals clocks If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_TIM13EN                    \ [0x08] TIM13 peripherals clocks If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $09 constant RCC_TIM14EN                    \ [0x09] TIM14 peripherals clocks If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0a constant RCC_TIM15EN                    \ [0x0a] TIM15 peripherals clocks If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0b constant RCC_TIM16EN                    \ [0x0b] TIM16 peripherals clocks If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0c constant RCC_TIM17EN                    \ [0x0c] TIM17 peripherals clocks If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB2ENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 peripheral clocks enable Set by software.
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2 peripheral clocks enable Set by software.
    $02 constant RCC_DMAMUX1EN                  \ [0x02] DMAMUX1 peripheral clocks enable Set by software.
    $03 constant RCC_DMA3EN                     \ [0x03] DMA3 peripheral clocks enable If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $04 constant RCC_DMAMUX2EN                  \ [0x04] DMAMUX2 peripheral clocks enable If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $05 constant RCC_ADC1EN                     \ [0x05] ADC1 peripheral clocks enable If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $06 constant RCC_ADC2EN                     \ [0x06] ADC2 peripheral clocks enable If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_USBOEN                     \ [0x08] USBO peripheral clocks enable If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB2ENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x754
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 peripheral clocks enable Cleared by software.
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2 peripheral clocks enable Cleared by software.
    $02 constant RCC_DMAMUX1EN                  \ [0x02] DMAMUX1 peripheral clocks enable Cleared by software.
    $03 constant RCC_DMA3EN                     \ [0x03] DMA3 peripheral clocks enable If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $04 constant RCC_DMAMUX2EN                  \ [0x04] DMAMUX2 peripheral clocks enable If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $05 constant RCC_ADC1EN                     \ [0x05] ADC1 peripheral clocks enable If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $06 constant RCC_ADC2EN                     \ [0x06] ADC2 peripheral clocks enable If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $08 constant RCC_USBOEN                     \ [0x08] USBO peripheral clocks enable If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB4ENSETR_DEF
    \
    \ @brief This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x760
    \ Reset value: 0x00000000
    \
    $0f constant RCC_TSCEN                      \ [0x0f] TSC peripheral clocks enable Set by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB4ENCLRR_DEF
    \
    \ @brief This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x764
    \ Reset value: 0x00000000
    \
    $0f constant RCC_TSCEN                      \ [0x0f] TSC peripheral clocks enable Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_S_AHB4ENSETR_DEF
    \
    \ @brief This is a secure register, for enabling the clock of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x768
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOA peripheral clocks enable Set by (secure) software.
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOB peripheral clocks enable Set by (secure) software.
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOC peripheral clocks enable Set by (secure) software.
    $03 constant RCC_GPIODEN                    \ [0x03] GPIOD peripheral clocks enable Set by (secure) software.
    $04 constant RCC_GPIOEEN                    \ [0x04] GPIOE peripheral clocks enable Set by (secure) software.
    $05 constant RCC_GPIOFEN                    \ [0x05] GPIOF peripheral clocks enable Set by (secure) software.
    $06 constant RCC_GPIOGEN                    \ [0x06] GPIOG peripheral clocks enable Set by (secure) software.
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOH peripheral clocks enable Set by (secure) software.
    $08 constant RCC_GPIOIEN                    \ [0x08] GPIOI peripheral clocks enable Set by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_S_AHB4ENCLRR_DEF
    \
    \ @brief This is a secure register, for disabling of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x76C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOA peripheral clocks enable Cleared by (secure) software.
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOB peripheral clocks enable Cleared by (secure) software.
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOC peripheral clocks enable Cleared by (secure) software.
    $03 constant RCC_GPIODEN                    \ [0x03] GPIOD peripheral clocks enable Cleared by (secure) software.
    $04 constant RCC_GPIOEEN                    \ [0x04] GPIOE peripheral clocks enable Cleared by (secure) software.
    $05 constant RCC_GPIOFEN                    \ [0x05] GPIOF peripheral clocks enable Cleared by (secure) software.
    $06 constant RCC_GPIOGEN                    \ [0x06] GPIOG peripheral clocks enable Cleared by (secure) software.
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOH peripheral clocks enable Cleared by (secure) software.
    $08 constant RCC_GPIOIEN                    \ [0x08] GPIOI peripheral clocks enable Cleared by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_NS_AHB4ENSETR_DEF
    \
    \ @brief This is a non-secure register, for enabling the non-secure GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x770
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOA peripheral clocks enable Set by software.
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOB peripheral clocks enable Set by software.
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOC peripheral clocks enable Set by software.
    $03 constant RCC_GPIODEN                    \ [0x03] GPIOD peripheral clocks enable Set by software.
    $04 constant RCC_GPIOEEN                    \ [0x04] GPIOE peripheral clocks enable Set by software.
    $05 constant RCC_GPIOFEN                    \ [0x05] GPIOF peripheral clocks enable Set by software.
    $06 constant RCC_GPIOGEN                    \ [0x06] GPIOG peripheral clocks enable Set by software.
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOH peripheral clocks enable Set by software.
    $08 constant RCC_GPIOIEN                    \ [0x08] GPIOI peripheral clocks enable Set by software.
  [then]


  [ifdef] RCC_RCC_MP_NS_AHB4ENCLRR_DEF
    \
    \ @brief This is a non-secure register, for disabling the non-secure GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x774
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOA peripheral clocks enable Cleared by software.
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOB peripheral clocks enable Cleared by software.
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOC peripheral clocks enable Cleared by software.
    $03 constant RCC_GPIODEN                    \ [0x03] GPIOD peripheral clocks enable Cleared by software.
    $04 constant RCC_GPIOEEN                    \ [0x04] GPIOE peripheral clocks enable Cleared by software.
    $05 constant RCC_GPIOFEN                    \ [0x05] GPIOF peripheral clocks enable Cleared by software.
    $06 constant RCC_GPIOGEN                    \ [0x06] GPIOG peripheral clocks enable Cleared by software.
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOH peripheral clocks enable Cleared by software.
    $08 constant RCC_GPIOIEN                    \ [0x08] GPIOI peripheral clocks enable Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB5ENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral to the MPU. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x778
    \ Reset value: 0x00010000
    \
    $02 constant RCC_PKAEN                      \ [0x02] PKA peripheral clocks enable If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $03 constant RCC_SAESEN                     \ [0x03] SAES peripheral clocks enable If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $04 constant RCC_CRYP1EN                    \ [0x04] CRYP (3DES/AES) peripheral clocks enable If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $05 constant RCC_HASH1EN                    \ [0x05] HASH peripheral clocks enable If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $06 constant RCC_RNG1EN                     \ [0x06] RNG1 peripheral clocks enable If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_BKPSRAMEN                  \ [0x08] BKPSRAM clocks enable If BKPSRAM is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $10 constant RCC_AXIMCEN                    \ [0x10] AXIMC clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_AHB5ENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x77C
    \ Reset value: 0x00010000
    \
    $02 constant RCC_PKAEN                      \ [0x02] PKA peripheral clocks enable If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $03 constant RCC_SAESEN                     \ [0x03] SAES peripheral clocks enable If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $04 constant RCC_CRYP1EN                    \ [0x04] CRYP (3DES/AES) peripheral clocks enable If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $05 constant RCC_HASH1EN                    \ [0x05] HASH peripheral clocks enable If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $06 constant RCC_RNG1EN                     \ [0x06] RNG1 peripheral clocks enable If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $08 constant RCC_BKPSRAMEN                  \ [0x08] BKPSRAM clocks enable If BKPSRAM is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $10 constant RCC_AXIMCEN                    \ [0x10] AXIMC clocks enable A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_AHB6ENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x780
    \ Reset value: 0x00000000
    \
    $01 constant RCC_MCEEN                      \ [0x01] MCE peripheral clocks enable If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $07 constant RCC_ETH1CKEN                   \ [0x07] Enable of the ETH1 clock generated by the RCC (eth1_ker_ck) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_ETH1TXEN                   \ [0x08] ETH1 transmission clock enable If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $09 constant RCC_ETH1RXEN                   \ [0x09] ETH1 reception clock enable If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0a constant RCC_ETH1MACEN                  \ [0x0a] ETH1 MAC bus interface clock enable (hclk6 and aclk) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0c constant RCC_FMCEN                      \ [0x0c] FMC peripheral clocks enable If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0e constant RCC_QSPIEN                     \ [0x0e] QUADSPI peripheral clocks enable If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $10 constant RCC_SDMMC1EN                   \ [0x10] SDMMC1 and SDMMC1 delay (DLYBSD1) block peripheral clocks enable If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $11 constant RCC_SDMMC2EN                   \ [0x11] SDMMC2 and SDMMC2 delay (DLYBSD2) block peripheral clocks enable If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $14 constant RCC_CRC1EN                     \ [0x14] CRC peripheral clocks enable Set by software.
    $18 constant RCC_USBHEN                     \ [0x18] USBH peripheral clocks enable Set by software.
    $1b constant RCC_ETH2CKEN                   \ [0x1b] Enable of the ETH2 clock generated by the RCC (eth2_ker_ck) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $1c constant RCC_ETH2TXEN                   \ [0x1c] ETH2 transmission clock enable If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $1d constant RCC_ETH2RXEN                   \ [0x1d] ETH2 reception clock enable If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $1e constant RCC_ETH2MACEN                  \ [0x1e] ETH2 MAC bus interface clock enable (hclk6 and aclk) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB6ENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x784
    \ Reset value: 0x00000000
    \
    $01 constant RCC_MCEEN                      \ [0x01] MCE peripheral clocks enable If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $07 constant RCC_ETH1CKEN                   \ [0x07] Enable of the ETH1 clock generated by the RCC (eth1_ker_ck) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $08 constant RCC_ETH1TXEN                   \ [0x08] ETH1 transmission clock enable If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $09 constant RCC_ETH1RXEN                   \ [0x09] ETH1 reception clock enable If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0a constant RCC_ETH1MACEN                  \ [0x0a] ETH1 MAC bus interface clock enable (hclk6 and aclk) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0c constant RCC_FMCEN                      \ [0x0c] FMC peripheral clocks enable If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0e constant RCC_QSPIEN                     \ [0x0e] QUADSPI peripheral clocks enable If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $10 constant RCC_SDMMC1EN                   \ [0x10] SDMMC1 and SDMMC1 delay (DLYBSD1) block peripheral clocks enable If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $11 constant RCC_SDMMC2EN                   \ [0x11] SDMMC2 and SDMMC2 delay (DLYBSD2) block peripheral clocks enable If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $14 constant RCC_CRC1EN                     \ [0x14] CRC peripheral clocks enable Cleared by software.
    $18 constant RCC_USBHEN                     \ [0x18] USBH peripheral clocks enable Cleared by software.
    $1b constant RCC_ETH2CKEN                   \ [0x1b] Enable of the ETH2 clock generated by the RCC (eth2_ker_ck) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $1c constant RCC_ETH2TXEN                   \ [0x1c] ETH2 transmission clock enable If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $1d constant RCC_ETH2RXEN                   \ [0x1d] ETH2 reception clock enable If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $1e constant RCC_ETH2MACEN                  \ [0x1e] ETH2 MAC bus interface clock enable (hclk6 and aclk) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_S_AHB6ENSETR_DEF
    \
    \ @brief This is a secure register for enabling the clock of the MDMA when it is used as secure. A write access to this register field must be secure. A read access may be secure or non- secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x788
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMA peripheral clocks enable Set by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_S_AHB6ENCLRR_DEF
    \
    \ @brief This is a secure register for disabling the clock of the MDMA when it is not used as secure. A write access to this register field must be secure. A read access may be secure or non- secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x78C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMA peripheral clocks enable Cleared by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_NS_AHB6ENSETR_DEF
    \
    \ @brief This is a non-secure register for enabling the clock of the MDMA when it is used as non- secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x790
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMA peripheral clocks enable Set by software.
  [then]


  [ifdef] RCC_RCC_MP_NS_AHB6ENCLRR_DEF
    \
    \ @brief This is a non-secure register for disabling the clock of the MDMA when it is not used as non- secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMA peripheral clocks enable Set by software.
  [then]


  [ifdef] RCC_RCC_MP_APB1LPENSETR_DEF
    \
    \ @brief This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x800
    \ Reset value: 0x046F9A3F
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2 peripheral clocks enable during CSleep mode Set by software.
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3 peripheral clocks enable during CSleep mode Set by software.
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4 peripheral clocks enable during CSleep mode Set by software.
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5 peripheral clocks enable during CSleep mode Set by software.
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6 peripheral clocks enable during CSleep mode Set by software.
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7 peripheral clocks enable during CSleep mode Set by software.
    $09 constant RCC_LPTIM1LPEN                 \ [0x09] LPTIM1 peripheral clocks enable during CSleep mode Set by software.
    $0b constant RCC_SPI2LPEN                   \ [0x0b] SPI2 peripheral clocks enable during CSleep mode Set by software.
    $0c constant RCC_SPI3LPEN                   \ [0x0c] SPI3 peripheral clocks enable during CSleep mode Set by software.
    $0f constant RCC_USART3LPEN                 \ [0x0f] USART3 peripheral clocks enable during CSleep mode Set by software.
    $10 constant RCC_UART4LPEN                  \ [0x10] UART4 peripheral clocks enable during CSleep mode Set by software.
    $11 constant RCC_UART5LPEN                  \ [0x11] UART5 peripheral clocks enable during CSleep mode Set by software.
    $12 constant RCC_UART7LPEN                  \ [0x12] UART7 peripheral clocks enable during CSleep mode Set by software.
    $13 constant RCC_UART8LPEN                  \ [0x13] UART8 peripheral clocks enable during CSleep mode Set by software.
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1 peripheral clocks enable during CSleep mode Set by software.
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2 peripheral clocks enable during CSleep mode Set by software.
    $1a constant RCC_SPDIFLPEN                  \ [0x1a] SPDIFRX peripheral clocks enable during CSleep mode Set by software.
  [then]


  [ifdef] RCC_RCC_MP_APB1LPENCLRR_DEF
    \
    \ @brief This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x804
    \ Reset value: 0x046F9A3F
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2 peripheral clocks enable during CSleep mode Cleared by software.
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3 peripheral clocks enable during CSleep mode Cleared by software.
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4 peripheral clocks enable during CSleep mode Cleared by software.
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5 peripheral clocks enable during CSleep mode Cleared by software.
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6 peripheral clocks enable during CSleep mode Cleared by software.
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7 peripheral clocks enable during CSleep mode Cleared by software.
    $09 constant RCC_LPTIM1LPEN                 \ [0x09] LPTIM1 peripheral clocks enable during CSleep mode Cleared by software.
    $0b constant RCC_SPI2LPEN                   \ [0x0b] SPI2 peripheral clocks enable during CSleep mode Cleared by software.
    $0c constant RCC_SPI3LPEN                   \ [0x0c] SPI3 peripheral clocks enable during CSleep mode Cleared by software.
    $0f constant RCC_USART3LPEN                 \ [0x0f] USART3 peripheral clocks enable during CSleep mode Cleared by software.
    $10 constant RCC_UART4LPEN                  \ [0x10] UART4 peripheral clocks enable during CSleep mode Cleared by software.
    $11 constant RCC_UART5LPEN                  \ [0x11] UART5 peripheral clocks enable during CSleep mode Cleared by software.
    $12 constant RCC_UART7LPEN                  \ [0x12] UART7 peripheral clocks enable during CSleep mode Cleared by software.
    $13 constant RCC_UART8LPEN                  \ [0x13] UART8 peripheral clocks enable during CSleep mode Cleared by software.
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1 peripheral clocks enable during CSleep mode Cleared by software.
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2 peripheral clocks enable during CSleep mode Cleared by software.
    $1a constant RCC_SPDIFLPEN                  \ [0x1a] SPDIFRX peripheral clocks enable during CSleep mode Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_APB2LPENSETR_DEF
    \
    \ @brief This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x808
    \ Reset value: 0x01332103
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1 peripheral clocks enable during CSleep mode Set by software.
    $01 constant RCC_TIM8LPEN                   \ [0x01] TIM8 peripheral clocks enable during CSleep mode Set by software.
    $08 constant RCC_SPI1LPEN                   \ [0x08] SPI/I2S1 peripheral clocks enable during CSleep mode Set by software.
    $0d constant RCC_USART6LPEN                 \ [0x0d] USART6 peripheral clocks enable during CSleep mode Set by software.
    $10 constant RCC_SAI1LPEN                   \ [0x10] SAI1 peripheral clocks enable during CSleep mode Set by software.
    $11 constant RCC_SAI2LPEN                   \ [0x11] SAI2 peripheral clocks enable during CSleep mode Set by software.
    $14 constant RCC_DFSDMLPEN                  \ [0x14] DFSDM peripheral clocks enable during CSleep mode Set by software.
    $15 constant RCC_ADFSDMLPEN                 \ [0x15] Audio DFSDM peripheral clocks enable during CSleep mode Set by software.
    $18 constant RCC_FDCANLPEN                  \ [0x18] FDCAN and CANRAM peripheral clocks enable during CSleep mode Set by software.
  [then]


  [ifdef] RCC_RCC_MP_APB2LPENCLRR_DEF
    \
    \ @brief This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x80C
    \ Reset value: 0x01332103
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1 peripheral clocks enable during CSleep mode Cleared by software.
    $01 constant RCC_TIM8LPEN                   \ [0x01] TIM8 peripheral clocks enable during CSleep mode Cleared by software.
    $08 constant RCC_SPI1LPEN                   \ [0x08] SPI/I2S1 peripheral clocks enable during CSleep mode Cleared by software.
    $0d constant RCC_USART6LPEN                 \ [0x0d] USART6 peripheral clocks enable during CSleep mode Cleared by software.
    $10 constant RCC_SAI1LPEN                   \ [0x10] SAI1 peripheral clocks enable during CSleep mode Cleared by software.
    $11 constant RCC_SAI2LPEN                   \ [0x11] SAI2 peripheral clocks enable during CSleep mode Cleared by software.
    $14 constant RCC_DFSDMLPEN                  \ [0x14] DFSDM peripheral clocks enable during CSleep mode Cleared by software.
    $15 constant RCC_ADFSDMLPEN                 \ [0x15] Audio DFSDM peripheral clocks enable during CSleep mode Cleared by software.
    $18 constant RCC_FDCANLPEN                  \ [0x18] FDCAN and CANRAM peripheral clocks enable during CSleep mode Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_APB3LPENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x810
    \ Reset value: 0x0003200F
    \
    $00 constant RCC_LPTIM2LPEN                 \ [0x00] LPTIM2 peripheral clocks enable during CSleep mode If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $01 constant RCC_LPTIM3LPEN                 \ [0x01] LPTIM3 peripheral clocks enable during CSleep mode If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $02 constant RCC_LPTIM4LPEN                 \ [0x02] LPTIM4 peripheral clocks enable during CSleep mode Set by software.
    $03 constant RCC_LPTIM5LPEN                 \ [0x03] LPTIM5 peripheral clocks enable during CSleep mode Set by software.
    $0d constant RCC_VREFLPEN                   \ [0x0d] VREF peripheral clocks enable during CSleep mode If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $10 constant RCC_DTSLPEN                    \ [0x10] DTS peripheral clocks enable during CSleep mode Set by software.
    $11 constant RCC_PMBCTRLLPEN                \ [0x11] PMBCTRL peripheral clocks enable during CSeep mode (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT
  [then]


  [ifdef] RCC_RCC_MP_APB3LPENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x814
    \ Reset value: 0x0003200F
    \
    $00 constant RCC_LPTIM2LPEN                 \ [0x00] LPTIM2 peripheral clocks enable during CSleep mode If LPTIM2 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $01 constant RCC_LPTIM3LPEN                 \ [0x01] LPTIM3 peripheral clocks enable during CSleep mode If LPTIM3 block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $02 constant RCC_LPTIM4LPEN                 \ [0x02] LPTIM4 peripheral clocks enable during CSleep mode Cleared by software.
    $03 constant RCC_LPTIM5LPEN                 \ [0x03] LPTIM5 peripheral clocks enable during CSleep mode Cleared by software.
    $0d constant RCC_VREFLPEN                   \ [0x0d] VREF peripheral clocks enable during CSleep mode If VREF block is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $10 constant RCC_DTSLPEN                    \ [0x10] DTS peripheral clocks enable during CSleep mode Cleared by software.
    $11 constant RCC_PMBCTRLLPEN                \ [0x11] PMBCTRL peripheral clocks enable during CSeep mode (non-user): this bit is present in the RTL and is internally used as: SPIRIT parameter RTLPRESENT
  [then]


  [ifdef] RCC_RCC_MP_S_APB3LPENSETR_DEF
    \
    \ @brief This is a secure register for enabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x818
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSCFGLPEN                 \ [0x00] SYSCFG peripheral clocks enable during CSleep mode Set by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_S_APB3LPENCLRR_DEF
    \
    \ @brief This is a secure register for disabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x81C
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSCFGLPEN                 \ [0x00] SYSCFG peripheral clocks enable during CSleep mode Cleared by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_NS_APB3LPENSETR_DEF
    \
    \ @brief This is a non-secure register, for enabling the clock of the SYSCFG. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x820
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSCFGLPEN                 \ [0x00] SYSCFG peripheral clocks enable during CSleep mode Set by software.
  [then]


  [ifdef] RCC_RCC_MP_NS_APB3LPENCLRR_DEF
    \
    \ @brief This is a non-secure register, for disabling the clock of the SYSCFG. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x824
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSCFGLPEN                 \ [0x00] SYSCFG peripheral clocks enable during CSleep mode Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_APB4LPENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x828
    \ Reset value: 0x00118102
    \
    $01 constant RCC_DCMIPPLPEN                 \ [0x01] DCMIPP peripheral clocks enable during CSleep mode If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_DDRPERFMLPEN               \ [0x08] DDRPERFM APB clock enable during CSleep mode Set by software.
    $0f constant RCC_IWDG2APBLPEN               \ [0x0f] IWDG2 APB clock enable during CSleep mode Set by software.
    $10 constant RCC_USBPHYLPEN                 \ [0x10] USBPHYC peripheral clocks enable during CSleep mode If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $14 constant RCC_STGENROLPEN                \ [0x14] STGEN read-only interface peripheral clocks enable during CSleep mode Set by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.
    $15 constant RCC_STGENROSTPEN               \ [0x15] STGEN read-only interface peripheral clocks enable during CStop mode Set by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.
  [then]


  [ifdef] RCC_RCC_MP_APB4LPENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x82C
    \ Reset value: 0x00118102
    \
    $01 constant RCC_DCMIPPLPEN                 \ [0x01] DCMIPP peripheral clocks enable during CSleep mode If DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $08 constant RCC_DDRPERFMLPEN               \ [0x08] DDRPERFM APB clock enable during CSleep mode Cleared by software.
    $0f constant RCC_IWDG2APBLPEN               \ [0x0f] IWDG2 APB clock enable during CSleep mode Cleared by software.
    $10 constant RCC_USBPHYLPEN                 \ [0x10] USBPHYC peripheral clocks enable during CSleep mode If USB PHY is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $14 constant RCC_STGENROLPEN                \ [0x14] STGEN read-only interface peripheral clocks enable during CSleep mode Cleared by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.
    $15 constant RCC_STGENROSTPEN               \ [0x15] STGEN read-only interface peripheral clocks enable during CStop mode Cleared by software. The peripheral clocks of the STGEN read-only interface are the pclk4, and the kernel clock as selected by the RCC_STGENCKSELR register.
  [then]


  [ifdef] RCC_RCC_MP_S_APB4LPENSETR_DEF
    \
    \ @brief This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x830
    \ Reset value: 0x00000001
    \
    $00 constant RCC_LTDCLPEN                   \ [0x00] LTDC peripheral clocks enable during CSleep mode Set by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_S_APB4LPENCLRR_DEF
    \
    \ @brief This is a secure register for disabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x834
    \ Reset value: 0x00000001
    \
    $00 constant RCC_LTDCLPEN                   \ [0x00] LTDC peripheral clocks enable during CSleep mode Cleared by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_NS_APB4LPENSETR_DEF
    \
    \ @brief This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x838
    \ Reset value: 0x00000001
    \
    $00 constant RCC_LTDCLPEN                   \ [0x00] LTDC peripheral clocks enable during CSleep mode Set by software.
  [then]


  [ifdef] RCC_RCC_MP_NS_APB4LPENCLRR_DEF
    \
    \ @brief This is a non-secure register, for disabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x83C
    \ Reset value: 0x00000001
    \
    $00 constant RCC_LTDCLPEN                   \ [0x00] LTDC peripheral clocks enable during CSleep mode Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_APB5LPENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x840
    \ Reset value: 0x0011A900
    \
    $08 constant RCC_RTCAPBLPEN                 \ [0x08] RTC APB clock enable during CSleep mode If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0b constant RCC_TZCLPEN                    \ [0x0b] TZC clocks enable during CSleep mode Set by (secure) software. See for details.
    $0d constant RCC_ETZPCLPEN                  \ [0x0d] ETZPC peripheral clocks enable during CSleep mode A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $0f constant RCC_IWDG1APBLPEN               \ [0x0f] IWDG1 APB clock enable during CSleep mode If IWDG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $10 constant RCC_BSECLPEN                   \ [0x10] BSEC peripheral clocks enable during CSleep mode A write access to this register field must be secure. A read access may be secure or non-secure. Set by (secure) software.
    $14 constant RCC_STGENCLPEN                 \ [0x14] STGEN controller part, peripheral clocks enable during CSleep mode If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.
    $15 constant RCC_STGENCSTPEN                \ [0x15] STGEN controller part, peripheral clocks enable during CStop mode If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.
  [then]


  [ifdef] RCC_RCC_MP_APB5LPENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x844
    \ Reset value: 0x0011A900
    \
    $08 constant RCC_RTCAPBLPEN                 \ [0x08] RTC APB clock enable during CSleep mode If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0b constant RCC_TZCLPEN                    \ [0x0b] TZC clocks enable during CSleep mode Cleared by (secure) software. See for details.
    $0d constant RCC_ETZPCLPEN                  \ [0x0d] ETZPC peripheral clocks enable during CSleep mode A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $0f constant RCC_IWDG1APBLPEN               \ [0x0f] IWDG1 APB clock enable during CSleep mode If IWDG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $10 constant RCC_BSECLPEN                   \ [0x10] BSEC peripheral clocks enable during CSleep mode A write access to this register field must be secure. A read access may be secure or non-secure. Cleared by (secure) software.
    $14 constant RCC_STGENCLPEN                 \ [0x14] STGEN controller part, peripheral clocks enable during CSleep mode If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.
    $15 constant RCC_STGENCSTPEN                \ [0x15] STGEN controller part, peripheral clocks enable during CStop mode If STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software. The peripheral clocks of the STGEN controller part are the pclk5, and the kernel clock as selected by the RCC_STGENCKSELR register.
  [then]


  [ifdef] RCC_RCC_MP_APB6LPENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x848
    \ Reset value: 0x00001FFF
    \
    $00 constant RCC_USART1LPEN                 \ [0x00] USART1 peripherals clocks during CSleep mode If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $01 constant RCC_USART2LPEN                 \ [0x01] USART2 peripherals clocks during CSleep mode If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $02 constant RCC_SPI4LPEN                   \ [0x02] SPI4 peripherals clocks during CSleep mode If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $03 constant RCC_SPI5LPEN                   \ [0x03] SPI5 peripherals clocks during CSleep mode If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $04 constant RCC_I2C3LPEN                   \ [0x04] I2C3 peripherals clocks during CSleep mode If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $05 constant RCC_I2C4LPEN                   \ [0x05] I2C4 peripherals clocks during CSleep mode If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $06 constant RCC_I2C5LPEN                   \ [0x06] I2C5 peripherals clocks during CSleep mode If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $07 constant RCC_TIM12LPEN                  \ [0x07] TIM12 peripherals clocks during CSleep mode If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $08 constant RCC_TIM13LPEN                  \ [0x08] TIM13 peripherals clocks during CSleep mode If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $09 constant RCC_TIM14LPEN                  \ [0x09] TIM14 peripherals clocks during CSleep mode If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0a constant RCC_TIM15LPEN                  \ [0x0a] TIM15 peripherals clocks during CSleep mode If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0b constant RCC_TIM16LPEN                  \ [0x0b] TIM16 peripherals clocks during CSleep mode If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0c constant RCC_TIM17LPEN                  \ [0x0c] TIM17 peripherals clocks during CSleep mode If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_APB6LPENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x84C
    \ Reset value: 0x00001FFF
    \
    $00 constant RCC_USART1LPEN                 \ [0x00] USART1 peripherals clocks during CSleep mode If USART1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $01 constant RCC_USART2LPEN                 \ [0x01] USART2 peripherals clocks during CSleep mode If USART2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $02 constant RCC_SPI4LPEN                   \ [0x02] SPI4 peripherals clocks during CSleep mode If SPI4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $03 constant RCC_SPI5LPEN                   \ [0x03] SPI5 peripherals clocks during CSleep mode If SPI5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $04 constant RCC_I2C3LPEN                   \ [0x04] I2C3 peripherals clocks during CSleep mode If I2C3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $05 constant RCC_I2C4LPEN                   \ [0x05] I2C4 peripherals clocks during CSleep mode If I2C4 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $06 constant RCC_I2C5LPEN                   \ [0x06] I2C5 peripherals clocks during CSleep mode If I2C5 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $07 constant RCC_TIM12LPEN                  \ [0x07] TIM12 peripherals clocks during CSleep mode If TIM12 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_TIM13LPEN                  \ [0x08] TIM13 peripherals clocks during CSleep mode If TIM13 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $09 constant RCC_TIM14LPEN                  \ [0x09] TIM14 peripherals clocks during CSleep mode If TIM14 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0a constant RCC_TIM15LPEN                  \ [0x0a] TIM15 peripherals clocks during CSleep mode If TIM15 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0b constant RCC_TIM16LPEN                  \ [0x0b] TIM16 peripherals clocks during CSleep mode If TIM16 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0c constant RCC_TIM17LPEN                  \ [0x0c] TIM17 peripherals clocks during CSleep mode If TIM17 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB2LPENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x850
    \ Reset value: 0x0000017F
    \
    $00 constant RCC_DMA1LPEN                   \ [0x00] DMA1 peripheral clocks enable during Sleep mode Set by software.
    $01 constant RCC_DMA2LPEN                   \ [0x01] DMA2 peripheral clocks enable during Sleep mode Set by software.
    $02 constant RCC_DMAMUX1LPEN                \ [0x02] DMAMUX1 peripheral clocks enable during Sleep mode Set by software.
    $03 constant RCC_DMA3LPEN                   \ [0x03] DMA3 peripheral clocks enable during Sleep mode If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $04 constant RCC_DMAMUX2LPEN                \ [0x04] DMAMUX2 peripheral clocks enable during Sleep mode If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $05 constant RCC_ADC1LPEN                   \ [0x05] ADC1 peripheral clocks enable during Sleep mode If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $06 constant RCC_ADC2LPEN                   \ [0x06] ADC2 peripheral clocks enable during Sleep mode If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_USBOLPEN                   \ [0x08] USBO peripheral clocks enable during Sleep mode If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB2LPENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x854
    \ Reset value: 0x0000017F
    \
    $00 constant RCC_DMA1LPEN                   \ [0x00] DMA1 peripheral clocks enable during Sleep mode Cleared by software.
    $01 constant RCC_DMA2LPEN                   \ [0x01] DMA2 peripheral clocks enable during Sleep mode Cleared by software.
    $02 constant RCC_DMAMUX1LPEN                \ [0x02] DMAMUX1 peripheral clocks enable during Sleep mode Cleared by software.
    $03 constant RCC_DMA3LPEN                   \ [0x03] DMA3 peripheral clocks enable during Sleep mode If DMA3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $04 constant RCC_DMAMUX2LPEN                \ [0x04] DMAMUX2 peripheral clocks enable during Sleep mode If DMAMUX2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $05 constant RCC_ADC1LPEN                   \ [0x05] ADC1 peripheral clocks enable during Sleep mode If ADC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $06 constant RCC_ADC2LPEN                   \ [0x06] ADC2 peripheral clocks enable during Sleep mode If ADC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $08 constant RCC_USBOLPEN                   \ [0x08] USBO peripheral clocks enable during Sleep mode If USBO is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB4LPENSETR_DEF
    \
    \ @brief This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x858
    \ Reset value: 0x00008000
    \
    $0f constant RCC_TSCLPEN                    \ [0x0f] TSC peripheral clocks enable during CSleep mode Set by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB4LPENCLRR_DEF
    \
    \ @brief RCC AHB4 Sleep clock enable clear register
    \ Address offset: 0x85C
    \ Reset value: 0x00008000
    \
    $0f constant RCC_TSCLPEN                    \ [0x0f] TSC peripheral clocks enable during CSleep mode Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_S_AHB4LPENSETR_DEF
    \
    \ @brief This is a secure register, for enabling the clock of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x868
    \ Reset value: 0x000001FF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOA peripheral clocks enable during CSleep mode Set by (secure) software.
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOB peripheral clocks enable during CSleep mode Set by (secure) software.
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOC peripheral clocks enable during CSleep mode Set by (secure) software.
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIOD peripheral clocks enable during CSleep mode Set by (secure) software.
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOE peripheral clocks enable during CSleep mode Set by (secure) software.
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOF peripheral clocks enable during CSleep mode Set by (secure) software.
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOG peripheral clocks enable during CSleep mode Set by (secure) software.
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOH peripheral clocks enable during CSleep mode Set by (secure) software.
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIOI peripheral clocks enable during CSleep mode Set by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_S_AHB4LPENCLRR_DEF
    \
    \ @brief This is a secure register, for disabling the clock of the secure (AHB4) GPIO ports
    \ Address offset: 0x86C
    \ Reset value: 0x000001FF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOA peripheral clocks enable during CSleep mode Cleared by (secure) software.
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOB peripheral clocks enable during CSleep mode Cleared by (secure) software.
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOC peripheral clocks enable during CSleep mode Cleared by (secure) software.
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIOD peripheral clocks enable during CSleep mode Cleared by (secure) software.
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOE peripheral clocks enable during CSleep mode Cleared by (secure) software.
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOF peripheral clocks enable during CSleep mode Cleared by (secure) software.
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOG peripheral clocks enable during CSleep mode Cleared by (secure) software.
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOH peripheral clocks enable during CSleep mode Cleared by (secure) software.
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIOI peripheral clocks enable during CSleep mode Cleared by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_NS_AHB4LPENSETR_DEF
    \
    \ @brief This is a non-secure register, for enabling the clock of the non-secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x870
    \ Reset value: 0x000001FF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOA peripheral clocks enable during CSleep mode Set by software.
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOB peripheral clocks enable during CSleep mode Set by software.
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOC peripheral clocks enable during CSleep mode Set by software.
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIOD peripheral clocks enable during CSleep mode Set by software.
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOE peripheral clocks enable during CSleep mode Set by software.
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOF peripheral clocks enable during CSleep mode Set by software.
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOG peripheral clocks enable during CSleep mode Set by software.
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOH peripheral clocks enable during CSleep mode Set by software.
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIOI peripheral clocks enable during CSleep mode Set by software.
  [then]


  [ifdef] RCC_RCC_MP_NS_AHB4LPENCLRR_DEF
    \
    \ @brief This is a non-secure register, for disabling the clock of the non-secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I).
    \ Address offset: 0x874
    \ Reset value: 0x000001FF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOA peripheral clocks enable during CSleep mode Cleared by software.
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOB peripheral clocks enable during CSleep mode Cleared by software.
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOC peripheral clocks enable during CSleep mode Cleared by software.
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIOD peripheral clocks enable during CSleep mode Cleared by software.
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOE peripheral clocks enable during CSleep mode Cleared by software.
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOF peripheral clocks enable during CSleep mode Cleared by software.
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOG peripheral clocks enable during CSleep mode Cleared by software.
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOH peripheral clocks enable during CSleep mode Cleared by software.
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIOI peripheral clocks enable during CSleep mode Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB5LPENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x878
    \ Reset value: 0x0000017C
    \
    $02 constant RCC_PKALPEN                    \ [0x02] PKA peripheral clocks enable during CSleep mode If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $03 constant RCC_SAESLPEN                   \ [0x03] SAES peripheral clocks enable during CSleep mode If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $04 constant RCC_CRYP1LPEN                  \ [0x04] CRYP (3DES/AES) peripheral clocks enable during CSleep mode If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $05 constant RCC_HASH1LPEN                  \ [0x05] HASH peripheral clocks enable during CSleep mode If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $06 constant RCC_RNG1LPEN                   \ [0x06] RNG1 peripheral clocks enable during CSleep mode If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_BKPSRAMLPEN                \ [0x08] BKPSRAM clocks enable during CSleep mode If BKPSRAM is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB5LPENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x87C
    \ Reset value: 0x0000017C
    \
    $02 constant RCC_PKALPEN                    \ [0x02] PKA peripheral clocks enable during CSleep mode If PKA is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $03 constant RCC_SAESLPEN                   \ [0x03] SAES peripheral clocks enable during CSleep mode If SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $04 constant RCC_CRYP1LPEN                  \ [0x04] CRYP (3DES/AES) peripheral clocks enable during CSleep mode If CRYP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $05 constant RCC_HASH1LPEN                  \ [0x05] HASH peripheral clocks enable during CSleep mode If HASH is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $06 constant RCC_RNG1LPEN                   \ [0x06] RNG1 peripheral clocks enable during CSleep mode If RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $08 constant RCC_BKPSRAMLPEN                \ [0x08] BKPSRAM clocks enable during CSleep mode If BKPSRAM is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_AHB6LPENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x880
    \ Reset value: 0x79135782
    \
    $01 constant RCC_MCELPEN                    \ [0x01] MCE peripheral clocks enable during CSleep mode If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $07 constant RCC_ETH1CKLPEN                 \ [0x07] Enable of the ETH1 clock generated by the RCC (eth1_ker_ck) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $08 constant RCC_ETH1TXLPEN                 \ [0x08] ETH1 transmission clock enable during CSleep mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $09 constant RCC_ETH1RXLPEN                 \ [0x09] ETH1 reception clock enable during CSleep mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0a constant RCC_ETH1MACLPEN                \ [0x0a] ETH1 MAC bus interface clock enable during CSleep mode (hclk6 and aclk) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0b constant RCC_ETH1STPEN                  \ [0x0b] ETH1 peripheral clock enable during CStop mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software in order to allow the ETH1 block to receive from pads ETH1_TX_CLK and ETH1_RX_CLK clocks during CStop.
    $0c constant RCC_FMCLPEN                    \ [0x0c] FMC peripheral clocks enable during CSleep mode If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $0e constant RCC_QSPILPEN                   \ [0x0e] QUADSPI peripheral clocks enable during CSleep mode If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $10 constant RCC_SDMMC1LPEN                 \ [0x10] SDMMC1 and SDMMC1 delay (DLYBSD1) block peripheral clocks enable during CSleep mode If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $11 constant RCC_SDMMC2LPEN                 \ [0x11] SDMMC2 and SDMMC2 delay (DLYBSD2) block peripheral clocks enable during CSleep mode If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $14 constant RCC_CRC1LPEN                   \ [0x14] CRC peripheral clocks enable during CSleep mode Set by software.
    $18 constant RCC_USBHLPEN                   \ [0x18] USBH peripheral clocks enable during CSleep mode Set by software.
    $1b constant RCC_ETH2CKLPEN                 \ [0x1b] Enable of the ETH2 clock generated by the RCC (eth2_ker_ck) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $1c constant RCC_ETH2TXLPEN                 \ [0x1c] ETH2 transmission clock enable during CSleep mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $1d constant RCC_ETH2RXLPEN                 \ [0x1d] ETH2 reception clock enable during CSleep mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $1e constant RCC_ETH2MACLPEN                \ [0x1e] ETH2 MAC bus interface clock enable during CSleep mode (hclk6 and aclk) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $1f constant RCC_ETH2STPEN                  \ [0x1f] ETH2 peripheral clock enable during CStop mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software in order to allow the ETH2 block to receive from pads ETH2_TX_CLK and ETH2_RX_CLK clocks during CStop.
  [then]


  [ifdef] RCC_RCC_MP_AHB6LPENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level.
    \ Address offset: 0x884
    \ Reset value: 0x79135782
    \
    $01 constant RCC_MCELPEN                    \ [0x01] MCE peripheral clocks enable during CSleep mode If MCE is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $07 constant RCC_ETH1CKLPEN                 \ [0x07] Enable of the ETH1 clock generated by the RCC (eth1_ker_ck) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $08 constant RCC_ETH1TXLPEN                 \ [0x08] ETH1 transmission clock enable during CSleep mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $09 constant RCC_ETH1RXLPEN                 \ [0x09] ETH1 reception clock enable during CSleep mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0a constant RCC_ETH1MACLPEN                \ [0x0a] ETH1 MAC bus interface clock enable during CSleep mode (hclk6 and aclk) If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0b constant RCC_ETH1STPEN                  \ [0x0b] ETH1 peripheral clock enable during CStop mode If ETH1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software in order to allow the ETH1 block to receive from pads ETH1_TX_CLK and ETH1_RX_CLK clocks during CStop.
    $0c constant RCC_FMCLPEN                    \ [0x0c] FMC peripheral clocks enable during CSleep mode If FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $0e constant RCC_QSPILPEN                   \ [0x0e] QUADSPI peripheral clocks enable during CSleep mode If QSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $10 constant RCC_SDMMC1LPEN                 \ [0x10] SDMMC1 and SDMMC1 delay (DLYBSD1) block peripheral clocks enable during CSleep mode If SDMMC1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $11 constant RCC_SDMMC2LPEN                 \ [0x11] SDMMC2 and SDMMC2 delay (DLYBSD2) block peripheral clocks enable during CSleep mode If SDMMC2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $14 constant RCC_CRC1LPEN                   \ [0x14] CRC peripheral clocks enable during CSleep mode Cleared by software.
    $18 constant RCC_USBHLPEN                   \ [0x18] USBH peripheral clocks enable during CSleep mode Cleared by software.
    $1b constant RCC_ETH2CKLPEN                 \ [0x1b] Enable of the ETH2 clock generated by the RCC (eth2_ker_ck) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $1c constant RCC_ETH2TXLPEN                 \ [0x1c] ETH2 transmission clock enable during CSleep mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $1d constant RCC_ETH2RXLPEN                 \ [0x1d] ETH2 reception clock enable during CSleep mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $1e constant RCC_ETH2MACLPEN                \ [0x1e] ETH2 MAC bus interface clock enable during CSleep mode (hclk6 and aclk) If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $1f constant RCC_ETH2STPEN                  \ [0x1f] ETH2 peripheral clock enable during CStop mode If ETH2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software in order to allow the ETH2 block to receive from pads ETH2_TX_CLK and ETH2_RX_CLK clocks during CStop.
  [then]


  [ifdef] RCC_RCC_MP_S_AHB6LPENSETR_DEF
    \
    \ @brief This is a secure register for enabling the clock of the MDMA in Sleep mode when it is used as secure. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x888
    \ Reset value: 0x00000001
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMA peripheral clocks enable during CSleep mode Set by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_S_AHB6LPENCLRR_DEF
    \
    \ @brief This is a secure register for disabling the clock of the MDMA in Sleep mode when it is not used as secure. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x88C
    \ Reset value: 0x00000001
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMA peripheral clocks enable during CSleep mode Cleared by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_NS_AHB6LPENSETR_DEF
    \
    \ @brief This is a non-secure register for enabling the clock of the MDMA in Sleep mode when it is not used as secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x890
    \ Reset value: 0x00000001
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMA peripheral clocks enable during CSleep mode Set by software.
  [then]


  [ifdef] RCC_RCC_MP_NS_AHB6LPENCLRR_DEF
    \
    \ @brief This is a non-secure register for disabling the clock of the MDMA in Sleep mode when it is not used as secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
    \ Address offset: 0x894
    \ Reset value: 0x00000001
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMA peripheral clocks enable during CSleep mode Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_S_AXIMLPENSETR_DEF
    \
    \ @brief This is a secure register, for enabling the clock of the SYSRAM during CSleep mode. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x898
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSRAMLPEN                 \ [0x00] SYSRAM interface clock enable during CSleep mode Set by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_S_AXIMLPENCLRR_DEF
    \
    \ @brief This is a secure register, for disabling the clock of the SYSRAM during CSleep mode.
    \ Address offset: 0x89C
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSRAMLPEN                 \ [0x00] SYSRAM interface clock enable during CSleep mode Cleared by (secure) software.
  [then]


  [ifdef] RCC_RCC_MP_NS_AXIMLPENSETR_DEF
    \
    \ @brief This is a non-secure register, for enabling the clock of the SYSRAM during CSleep mode. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x8A0
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSRAMLPEN                 \ [0x00] SYSRAM interface clock enable during CSleep mode Set by software.
  [then]


  [ifdef] RCC_RCC_MP_NS_AXIMLPENCLRR_DEF
    \
    \ @brief This is a non-secure register, for disabling the clock of the SYSRAM during CSleep mode.
    \ Address offset: 0x8A4
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSRAMLPEN                 \ [0x00] SYSRAM interface clock enable during CSleep mode Cleared by software.
  [then]


  [ifdef] RCC_RCC_MP_MLAHBLPENSETR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
    \ Address offset: 0x8A8
    \ Reset value: 0x00000007
    \
    $00 constant RCC_SRAM1LPEN                  \ [0x00] SRAM1 interface clock enable during CSleep mode If SRAM1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $01 constant RCC_SRAM2LPEN                  \ [0x01] SRAM2 interface clock enable during CSleep mode If SRAM2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
    $02 constant RCC_SRAM3LPEN                  \ [0x02] SRAM3 interface clock enable during CSleep mode If SRAM3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Set by software.
  [then]


  [ifdef] RCC_RCC_MP_MLAHBLPENCLRR_DEF
    \
    \ @brief This register may be separately and securely write-protected at a field level
    \ Address offset: 0x8AC
    \ Reset value: 0x00000007
    \
    $00 constant RCC_SRAM1LPEN                  \ [0x00] SRAM1 interface clock enable during CSleep mode If SRAM1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $01 constant RCC_SRAM2LPEN                  \ [0x01] SRAM2 interface clock enable during CSleep mode If SRAM2 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
    $02 constant RCC_SRAM3LPEN                  \ [0x02] SRAM3 interface clock enable during CSleep mode If SRAM3 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register field must be secure. A read access may be secure or non-secure. Cleared by software.
  [then]


  [ifdef] RCC_RCC_APB3SECSR_DEF
    \
    \ @brief This read register reflects at a bit level the secure state of each APB3 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    \ Address offset: 0x8C0
    \ Reset value: 0x00004003
    \
    $00 constant RCC_LPTIM2SECF                 \ [0x00] LPTIM2 block secure status flag This bit reflects the LPTIM2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $01 constant RCC_LPTIM3SECF                 \ [0x01] LPTIM3 block secure status flag This bit reflects the LPTIM3 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $0d constant RCC_VREFSECF                   \ [0x0d] VREF block secure status flag This bit reflects the VREF block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  [then]


  [ifdef] RCC_RCC_APB4SECSR_DEF
    \
    \ @brief This read register reflects at a bit level the secure state of each APB4 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    \ Address offset: 0x8C4
    \ Reset value: 0x00010002
    \
    $01 constant RCC_DCMIPPSECF                 \ [0x01] DCMIPP block secure status flag This bit reflects the DCMIPP block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $10 constant RCC_USBPHYSECF                 \ [0x10] USBPHY block secure status flag This bit reflects the USBPHY block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  [then]


  [ifdef] RCC_RCC_APB5SECSR_DEF
    \
    \ @brief This read register reflects at a bit level the secure state of each APB5 secure or securable peripheral, as configured either via the corresponding DECPROT[1] field of the ETZPC register or via the TrustZone-aware peripheral itself.
    \ Address offset: 0x8C8
    \ Reset value: 0x0031A800
    \
    $08 constant RCC_RTCSECF                    \ [0x08] RTC block secure status flag This bit reflects the RTC block secure state. If at least one function of the RTC is configured as secure via the RTC_SECCFGR register (i.e. if the input signal rtc_sec driven by RTC is asserted), this bit is asserted.
    $0b constant RCC_TZCSECF                    \ [0x0b] TZC block secure status flag This bit reflects the TZC block secure state.
    $0d constant RCC_ETZPCSECF                  \ [0x0d] ETZPC block secure status flag This bit reflects the ETZPC block secure state.
    $0f constant RCC_IWDG1SECF                  \ [0x0f] IWDG1 block secure status flag This bit reflects the IWDG1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $10 constant RCC_BSECSECF                   \ [0x10] BSEC block secure status flag This bit reflects the BSEC block secure state.
    $14 constant RCC_STGENCSECF                 \ [0x14 : 2] STGENC block secure status flag This field reflects the STGENC block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  [then]


  [ifdef] RCC_RCC_APB6SECSR_DEF
    \
    \ @brief This read register reflects at a bit level the secure state of each APB6 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    \ Address offset: 0x8CC
    \ Reset value: 0x00001FFF
    \
    $00 constant RCC_USART1SECF                 \ [0x00] USART1 block secure status flag This bit reflects the USART1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $01 constant RCC_USART2SECF                 \ [0x01] USART2 block secure status flag This bit reflects the USART2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $02 constant RCC_SPI4SECF                   \ [0x02] SPI4 block secure status flag This bit reflects the SPI4 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $03 constant RCC_SPI5SECF                   \ [0x03] SPI5 block secure status flag This bit reflects the SPI5 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $04 constant RCC_I2C3SECF                   \ [0x04] I2C3 block secure status flag This bit reflects the I2C3 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $05 constant RCC_I2C4SECF                   \ [0x05] I2C4 block secure status flag This bit reflects the I2C4 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $06 constant RCC_I2C5SECF                   \ [0x06] I2C5 block secure status flag This bit reflects the I2C5 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $07 constant RCC_TIM12SECF                  \ [0x07] TIM12 block secure status flag This bit reflects the TIM12 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $08 constant RCC_TIM13SECF                  \ [0x08] TIM13 block secure status flag This bit reflects the TIM13 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $09 constant RCC_TIM14SECF                  \ [0x09] TIM14 block secure status flag This bit reflects the TIM14 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $0a constant RCC_TIM15SECF                  \ [0x0a] TIM15 block secure status flag This bit reflects the TIM15 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $0b constant RCC_TIM16SECF                  \ [0x0b] TIM16 block secure status flag This bit reflects the TIM16 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $0c constant RCC_TIM17SECF                  \ [0x0c] TIM17 block secure status flag This bit reflects the TIM17 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  [then]


  [ifdef] RCC_RCC_AHB2SECSR_DEF
    \
    \ @brief This read register reflects at a bit level the secure state of each AHB2 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    \ Address offset: 0x8D0
    \ Reset value: 0x00000178
    \
    $03 constant RCC_DMA3SECF                   \ [0x03] DMA3 block secure status flag This bit reflects the DMA3 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $04 constant RCC_DMAMUX2SECF                \ [0x04] DMAMUX2 block secure status flag This bit reflects the DMAMUX2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $05 constant RCC_ADC1SECF                   \ [0x05] ADC1 block secure status flag This bit reflects the ADC1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $06 constant RCC_ADC2SECF                   \ [0x06] ADC2 block secure status flag This bit reflects the ADC2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $08 constant RCC_USBOSECF                   \ [0x08] USBO block secure status flag This bit reflects the USBO block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  [then]


  [ifdef] RCC_RCC_AHB4SECSR_DEF
    \
    \ @brief This read register reflects at a bit level the secure state of each AHB4 securable peripheral, as configured either via the corresponding DECPROT[1] field of the ETZPC register or via the TrustZone-aware peripheral itself.
    \ Address offset: 0x8D4
    \ Reset value: 0x00004000
    \
    $0f constant RCC_TSCSECF                    \ [0x0f] TSC block secure status flag This bit reflects the TSC block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  [then]


  [ifdef] RCC_RCC_AHB5SECSR_DEF
    \
    \ @brief This read register reflects at a bit level the secure state of each AHB5 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    \ Address offset: 0x8D8
    \ Reset value: 0x0000017C
    \
    $02 constant RCC_PKASECF                    \ [0x02] PKA block secure status flag This bit reflects the PKA block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $03 constant RCC_SAESSECF                   \ [0x03] SAES block secure status flag This bit reflects the SAES block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $04 constant RCC_CRYP1SECF                  \ [0x04] CRYP1 block secure status flag This bit reflects the CRYP1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $05 constant RCC_HASH1SECF                  \ [0x05] HASH1 block secure status flag This bit reflects the HASH1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $06 constant RCC_RNG1SECF                   \ [0x06] RNG1 block secure status flag This bit reflects the RNG1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $08 constant RCC_BKPSRAMSECF                \ [0x08] BKPSRAM block secure status flag This bit reflects the BKPSRAM block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  [then]


  [ifdef] RCC_RCC_AHB6SECSR_DEF
    \
    \ @brief This read register reflects at a bit level the secure state of each AHB6 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    \ Address offset: 0x8DC
    \ Reset value: 0xF8035F82
    \
    $01 constant RCC_MCESECF                    \ [0x01] MCE block secure status flag This bit reflects the MCE block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $07 constant RCC_ETH1SECF                   \ [0x07 : 5] ETH1 block secure status flag This field reflects the ETH1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $0c constant RCC_FMCSECF                    \ [0x0c] FMC block secure status flag This bit reflects the FMC block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $0e constant RCC_QSPISECF                   \ [0x0e] QSPI block secure status flag This bit reflects the QSPI block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $10 constant RCC_SDMMC1SECF                 \ [0x10] SDMMC1 block secure status flag This bit reflects the SDMMC1 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $11 constant RCC_SDMMC2SECF                 \ [0x11] SDMMC2 block secure status flag This bit reflects the SDMMC2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
    $1b constant RCC_ETH2SECF                   \ [0x1b : 5] ETH2 block secure status flag This field reflects the ETH2 block secure state, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  [then]


  [ifdef] RCC_RCC_VERR_DEF
    \
    \ @brief This register gives the IP version
    \ Address offset: 0xFF4
    \ Reset value: 0x00000020
    \
    $00 constant RCC_MINREV                     \ [0x00 : 4] Minor Revision of the IP
    $04 constant RCC_MAJREV                     \ [0x04 : 4] Major Revision of the IP
  [then]


  [ifdef] RCC_RCC_IDR_DEF
    \
    \ @brief This register gives the unique identifier of the RCC
    \ Address offset: 0xFF8
    \ Reset value: 0x00000001
    \
    $00 constant RCC_ID                         \ [0x00 : 32] Identifier of the RCC
  [then]


  [ifdef] RCC_RCC_SIDR_DEF
    \
    \ @brief This register gives the decoding space, which is for the RCC of 4 kB.
    \ Address offset: 0xFFC
    \ Reset value: 0xA3C5DD04
    \
    $00 constant RCC_SID                        \ [0x00 : 32] Decoding space is 4 kbytes
  [then]

  \
  \ @brief RCC
  \
  $00 constant RCC_RCC_SECCFGR          \ RCC secure configuration register
  $100 constant RCC_RCC_MP_SREQSETR     \ RCC stop request set register
  $104 constant RCC_RCC_MP_SREQCLRR     \ RCC stop request clear register
  $108 constant RCC_RCC_MP_APRSTCR      \ RCC application reset control register
  $10C constant RCC_RCC_MP_APRSTSR      \ RCC application reset status register
  $110 constant RCC_RCC_PWRLPDLYCR      \ RCC low-power Stop modes delay control register
  $114 constant RCC_RCC_MP_GRSTCSETR    \ RCC global reset control set register
  $118 constant RCC_RCC_BR_RSTSCLRR     \ RCC BOOTROM reset status clear register
  $11C constant RCC_RCC_MP_RSTSSETR     \ RCC reset status set register
  $120 constant RCC_RCC_MP_RSTSCLRR     \ RCC reset status clear register
  $124 constant RCC_RCC_MP_IWDGFZSETR   \ RCC IWDG clock freeze set register
  $128 constant RCC_RCC_MP_IWDGFZCLRR   \ RCC IWDG clock freeze clear register
  $200 constant RCC_RCC_MP_CIER         \ RCC clock source interrupt enable register
  $204 constant RCC_RCC_MP_CIFR         \ RCC clock source interrupt flag register
  $400 constant RCC_RCC_BDCR            \ RCC backup domain control register
  $404 constant RCC_RCC_RDLSICR         \ RCC reset duration and LSI control register
  $420 constant RCC_RCC_OCENSETR        \ RCC oscillator clock enable set register
  $424 constant RCC_RCC_OCENCLRR        \ RCC oscillator clock enable clear register
  $428 constant RCC_RCC_OCRDYR          \ RCC oscillators and MPU and AXI clock ready register
  $440 constant RCC_RCC_HSICFGR         \ RCC HSI configuration register
  $444 constant RCC_RCC_CSICFGR         \ RCC CSI configuration register
  $460 constant RCC_RCC_MCO1CFGR        \ RCC MCO1 configuration register
  $464 constant RCC_RCC_MCO2CFGR        \ RCC MCO2 configuration register
  $468 constant RCC_RCC_DBGCFGR         \ RCC debug configuration register
  $480 constant RCC_RCC_RCK12SELR       \ RCC PLL1 and PLL2 reference clock selection register
  $484 constant RCC_RCC_RCK3SELR        \ RCC PLL3 reference clock selection register
  $488 constant RCC_RCC_RCK4SELR        \ RCC PLL4 reference clock selection register
  $4A0 constant RCC_RCC_PLL1CR          \ RCC PLL1 control register
  $4A4 constant RCC_RCC_PLL1CFGR1       \ RCC PLL1 configuration register 1
  $4A8 constant RCC_RCC_PLL1CFGR2       \ RCC PLL1 configuration register 2
  $4AC constant RCC_RCC_PLL1FRACR       \ RCC PLL1 fractional register
  $4B0 constant RCC_RCC_PLL1CSGR        \ RCC PLL1 clock spreading generator register
  $4D0 constant RCC_RCC_PLL2CR          \ RCC PLL2 control register
  $4D4 constant RCC_RCC_PLL2CFGR1       \ RCC PLL2 configuration register 1
  $4D8 constant RCC_RCC_PLL2CFGR2       \ RCC PLL2 configuration register 2
  $4DC constant RCC_RCC_PLL2FRACR       \ RCC PLL2 fractional register
  $4E0 constant RCC_RCC_PLL2CSGR        \ RCC PLL2 clock spreading generator register
  $500 constant RCC_RCC_PLL3CR          \ RCC PLL3 control register
  $504 constant RCC_RCC_PLL3CFGR1       \ RCC PLL3 configuration register 1
  $508 constant RCC_RCC_PLL3CFGR2       \ RCC PLL3 configuration register 2
  $50C constant RCC_RCC_PLL3FRACR       \ RCC PLL3 Fractional register
  $510 constant RCC_RCC_PLL3CSGR        \ RCC PLL3 clock spreading generator register
  $520 constant RCC_RCC_PLL4CR          \ RCC PLL4 control register
  $524 constant RCC_RCC_PLL4CFGR1       \ RCC PLL4 configuration register 1
  $528 constant RCC_RCC_PLL4CFGR2       \ RCC PLL4 configuration register 2
  $52C constant RCC_RCC_PLL4FRACR       \ RCC PLL4 fractional register
  $530 constant RCC_RCC_PLL4CSGR        \ RCC PLL4 clock spreading generator register
  $540 constant RCC_RCC_MPCKSELR        \ RCC MPU clock selection register
  $544 constant RCC_RCC_ASSCKSELR       \ RCC AXI sub-system clock selection register.
  $548 constant RCC_RCC_MSSCKSELR       \ RCC MLAHB sub-system clock selection register
  $54C constant RCC_RCC_CPERCKSELR      \ RCC common peripheral kernel clock selection register
  $560 constant RCC_RCC_RTCDIVR         \ RCC RTC clock division register
  $564 constant RCC_RCC_MPCKDIVR        \ RCC MPU clock divider register
  $568 constant RCC_RCC_AXIDIVR         \ RCC AXI clock divider register
  $56C constant RCC_RCC_MLAHBDIVR       \ RCC MLAHB clock divider register
  $570 constant RCC_RCC_APB1DIVR        \ RCC APB1 clock divider register
  $574 constant RCC_RCC_APB2DIVR        \ RCC APB2 clock divider register
  $578 constant RCC_RCC_APB3DIVR        \ RCC APB3 clock divider register
  $57C constant RCC_RCC_APB4DIVR        \ RCC APB4 clock divider register.
  $580 constant RCC_RCC_APB5DIVR        \ RCC APB5 clock divider register
  $584 constant RCC_RCC_APB6DIVR        \ RCC APB6 clock divider register
  $5A0 constant RCC_RCC_TIMG1PRER       \ RCC APB1 timers group1 prescaler register.
  $5A4 constant RCC_RCC_TIMG2PRER       \ RCC APB2 timers group2 prescaler register
  $5A8 constant RCC_RCC_TIMG3PRER       \ RCC APB6 timers group3 prescaler register
  $5C0 constant RCC_RCC_DDRITFCR        \ RCC DDR interface control register
  $600 constant RCC_RCC_I2C12CKSELR     \ RCC I2C1 and I2C2 kernel clock selection register
  $604 constant RCC_RCC_I2C345CKSELR    \ RCC I2C3, I2C4 and I2C5 kernel clock selection register.
  $608 constant RCC_RCC_SPI2S1CKSELR    \ RCC SPI/I2S1 kernel clock selection register
  $60C constant RCC_RCC_SPI2S23CKSELR   \ RCC SPI/I2S2 and SPI/I2S3 kernel clock selection register
  $610 constant RCC_RCC_SPI45CKSELR     \ RCC SPI/I2S4 and SPI5 kernel clock selection register
  $614 constant RCC_RCC_UART12CKSELR    \ RCC USART1 and USART2 kernel clock selection register
  $618 constant RCC_RCC_UART35CKSELR    \ RCC USART3 and UART5 kernel clock selection register
  $61C constant RCC_RCC_UART4CKSELR     \ RCC UART4 kernel clock selection register
  $620 constant RCC_RCC_UART6CKSELR     \ RCC USART6 kernel clock selection register
  $624 constant RCC_RCC_UART78CKSELR    \ RCC UART7 and UART8 kernel clock selection register
  $628 constant RCC_RCC_LPTIM1CKSELR    \ RCC LPTIM1 kernel clock selection register
  $62C constant RCC_RCC_LPTIM23CKSELR   \ RCC LPTIM2 and LPTIM3 kernel clock selection register
  $630 constant RCC_RCC_LPTIM45CKSELR   \ RCC LPTIM4 and LPTIM5 kernel clock selection register
  $634 constant RCC_RCC_SAI1CKSELR      \ RCC SAI1 kernel clock selection register
  $638 constant RCC_RCC_SAI2CKSELR      \ RCC SAI2 kernel clock selection register
  $63C constant RCC_RCC_FDCANCKSELR     \ RCC FDCAN kernel clock selection register
  $640 constant RCC_RCC_SPDIFCKSELR     \ RCC SPDIFRX kernel clock selection register
  $644 constant RCC_RCC_ADC12CKSELR     \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the (AHB2) ADC1 and ADC2 blocks. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
  $648 constant RCC_RCC_SDMMC12CKSELR   \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the (AHB6) SDMMC1 and SDMMC2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
  $64C constant RCC_RCC_ETH12CKSELR     \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the ETH1 and ETH2 blocks. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
  $650 constant RCC_RCC_USBCKSELR       \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to control the selection of the kernel clock for the USBPHY PLL of the USB Host (USBH) and the USB On-The-Go (USBO). It also controls the pre-divider for the reference clock for the USBPHY. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
  $654 constant RCC_RCC_QSPICKSELR      \ If (AHB6) QUADSPI is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the QUADSPI. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
  $658 constant RCC_RCC_FMCCKSELR       \ If (AHB6) FMC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the FMC block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
  $65C constant RCC_RCC_RNG1CKSELR      \ If (AHB5) RNG1 is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the RNG1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
  $660 constant RCC_RCC_STGENCKSELR     \ If (APB5) STGENC is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. STGEN is a dual APB interface IP, with STGENC APB5 controller part which may be secure or non-secure depending on the corresponding DECPROT[1]. Its other STGENRO APB4 read-only interface is non-secure. This register is used to select the peripheral clock for the STGEN block. Note that this clock is used to provide a time reference for the application. Refer to SectionÂ : Clock enabling delays.
  $664 constant RCC_RCC_DCMIPPCKSELR    \ If (APB4) DCMIPP is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the DCMIPP block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
  $668 constant RCC_RCC_SAESCKSELR      \ If (AHB5) SAES is configured as secure via the corresponding DECPROT[1] field of the ETZPC register, a write access to this register must be secure. A read access may be secure or non-secure. This register is used to control the selection of the kernel clock for the SAES block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to SectionÂ : Clock enabling delays.
  $6A0 constant RCC_RCC_APB1RSTSETR     \ This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
  $6A4 constant RCC_RCC_APB1RSTCLRR     \ This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
  $6A8 constant RCC_RCC_APB2RSTSETR     \ This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
  $6AC constant RCC_RCC_APB2RSTCLRR     \ This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
  $6B0 constant RCC_RCC_APB3RSTSETR     \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
  $6B4 constant RCC_RCC_APB3RSTCLRR     \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
  $6B8 constant RCC_RCC_APB4RSTSETR     \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
  $6BC constant RCC_RCC_APB4RSTCLRR     \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
  $6C0 constant RCC_RCC_APB5RSTSETR     \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
  $6C4 constant RCC_RCC_APB5RSTCLRR     \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
  $6C8 constant RCC_RCC_APB6RSTSETR     \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
  $6CC constant RCC_RCC_APB6RSTCLRR     \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
  $6D0 constant RCC_RCC_AHB2RSTSETR     \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
  $6D4 constant RCC_RCC_AHB2RSTCLRR     \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
  $6E0 constant RCC_RCC_AHB4RSTSETR     \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
  $6E4 constant RCC_RCC_AHB4RSTCLRR     \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
  $6E8 constant RCC_RCC_AHB5RSTSETR     \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
  $6EC constant RCC_RCC_AHB5RSTCLRR     \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
  $6F0 constant RCC_RCC_AHB6RSTSETR     \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to activate the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' activates the reset of the corresponding peripheral.
  $6F4 constant RCC_RCC_AHB6RSTCLRR     \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to release the reset of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' releases the reset of the corresponding peripheral.
  $700 constant RCC_RCC_MP_APB1ENSETR   \ This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective value of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $704 constant RCC_RCC_MP_APB1ENCLRR   \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $708 constant RCC_RCC_MP_APB2ENSETR   \ This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $70C constant RCC_RCC_MP_APB2ENCLRR   \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to â0â.
  $710 constant RCC_RCC_MP_APB3ENSETR   \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $714 constant RCC_RCC_MP_APB3ENCLRR   \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $718 constant RCC_RCC_MP_S_APB3ENSETR \ This is a secure register for enabling the clock of the SYSCFG.
  $71C constant RCC_RCC_MP_S_APB3ENCLRR \ This is a secure register for disabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $720 constant RCC_RCC_MP_NS_APB3ENSETR    \ This is a non-secure register, for enabling the clock of the SYSCFG.
  $724 constant RCC_RCC_MP_NS_APB3ENCLRR    \ This is a non-secure register, for disabling the clock of the SYSCFG.
  $728 constant RCC_RCC_MP_APB4ENSETR   \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $72C constant RCC_RCC_MP_APB4ENCLRR   \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $730 constant RCC_RCC_MP_S_APB4ENSETR \ This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $734 constant RCC_RCC_MP_S_APB4ENCLRR \ This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer.
  $738 constant RCC_RCC_MP_NS_APB4ENSETR    \ This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $73C constant RCC_RCC_MP_NS_APB4ENCLRR    \ This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers.
  $740 constant RCC_RCC_MP_APB5ENSETR   \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $744 constant RCC_RCC_MP_APB5ENCLRR   \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $748 constant RCC_RCC_MP_APB6ENSETR   \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $74C constant RCC_RCC_MP_APB6ENCLRR   \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $750 constant RCC_RCC_MP_AHB2ENSETR   \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $754 constant RCC_RCC_MP_AHB2ENCLRR   \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $760 constant RCC_RCC_MP_AHB4ENSETR   \ This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $764 constant RCC_RCC_MP_AHB4ENCLRR   \ This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $768 constant RCC_RCC_MP_S_AHB4ENSETR \ This is a secure register, for enabling the clock of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $76C constant RCC_RCC_MP_S_AHB4ENCLRR \ This is a secure register, for disabling of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $770 constant RCC_RCC_MP_NS_AHB4ENSETR    \ This is a non-secure register, for enabling the non-secure GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $774 constant RCC_RCC_MP_NS_AHB4ENCLRR    \ This is a non-secure register, for disabling the non-secure GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $778 constant RCC_RCC_MP_AHB5ENSETR   \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral to the MPU. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $77C constant RCC_RCC_MP_AHB5ENCLRR   \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $780 constant RCC_RCC_MP_AHB6ENSETR   \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $784 constant RCC_RCC_MP_AHB6ENCLRR   \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $788 constant RCC_RCC_MP_S_AHB6ENSETR \ This is a secure register for enabling the clock of the MDMA when it is used as secure. A write access to this register field must be secure. A read access may be secure or non- secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $78C constant RCC_RCC_MP_S_AHB6ENCLRR \ This is a secure register for disabling the clock of the MDMA when it is not used as secure. A write access to this register field must be secure. A read access may be secure or non- secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $790 constant RCC_RCC_MP_NS_AHB6ENSETR    \ This is a non-secure register for enabling the clock of the MDMA when it is used as non- secure. This register is used to set the peripheral clock enable bit of the corresponding peripheral. It shall be used to allocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $794 constant RCC_RCC_MP_NS_AHB6ENCLRR    \ This is a non-secure register for disabling the clock of the MDMA when it is not used as non- secure. This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $800 constant RCC_RCC_MP_APB1LPENSETR \ This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $804 constant RCC_RCC_MP_APB1LPENCLRR \ This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $808 constant RCC_RCC_MP_APB2LPENSETR \ This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $80C constant RCC_RCC_MP_APB2LPENCLRR \ This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $810 constant RCC_RCC_MP_APB3LPENSETR \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $814 constant RCC_RCC_MP_APB3LPENCLRR \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $818 constant RCC_RCC_MP_S_APB3LPENSETR    \ This is a secure register for enabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $81C constant RCC_RCC_MP_S_APB3LPENCLRR    \ This is a secure register for disabling the clock of the SYSCFG. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $820 constant RCC_RCC_MP_NS_APB3LPENSETR    \ This is a non-secure register, for enabling the clock of the SYSCFG. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $824 constant RCC_RCC_MP_NS_APB3LPENCLRR    \ This is a non-secure register, for disabling the clock of the SYSCFG. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $828 constant RCC_RCC_MP_APB4LPENSETR \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $82C constant RCC_RCC_MP_APB4LPENCLRR \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $830 constant RCC_RCC_MP_S_APB4LPENSETR    \ This is a secure register for enabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $834 constant RCC_RCC_MP_S_APB4LPENCLRR    \ This is a secure register for disabling the clock of the LTDC when it is used with a secure composition layer. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $838 constant RCC_RCC_MP_NS_APB4LPENSETR    \ This is a non-secure register, for enabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $83C constant RCC_RCC_MP_NS_APB4LPENCLRR    \ This is a non-secure register, for disabling the clock of the LTDC when it is used with one or two non-secure composition layers. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $840 constant RCC_RCC_MP_APB5LPENSETR \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $844 constant RCC_RCC_MP_APB5LPENCLRR \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $848 constant RCC_RCC_MP_APB6LPENSETR \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $84C constant RCC_RCC_MP_APB6LPENCLRR \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $850 constant RCC_RCC_MP_AHB2LPENSETR \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $854 constant RCC_RCC_MP_AHB2LPENCLRR \ This register may be separately and securely write-protected at a field level depending on the secure state of the corresponding peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $858 constant RCC_RCC_MP_AHB4LPENSETR \ This register may be write-protected depending on the secure state of the TSC peripheral, i.e. depending on the corresponding DECPROT[1] field of the ETZPC register. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $85C constant RCC_RCC_MP_AHB4LPENCLRR \ RCC AHB4 Sleep clock enable clear register
  $868 constant RCC_RCC_MP_S_AHB4LPENSETR    \ This is a secure register, for enabling the clock of the secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $86C constant RCC_RCC_MP_S_AHB4LPENCLRR    \ This is a secure register, for disabling the clock of the secure (AHB4) GPIO ports
  $870 constant RCC_RCC_MP_NS_AHB4LPENSETR    \ This is a non-secure register, for enabling the clock of the non-secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I). This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $874 constant RCC_RCC_MP_NS_AHB4LPENCLRR    \ This is a non-secure register, for disabling the clock of the non-secure (AHB4) GPIO ports, as defined by the GPIO register file and more specifically the GPIOxSECCFGR.SECy control bit with x=A..I, and y = 0..15 (or 2 for x=I).
  $878 constant RCC_RCC_MP_AHB5LPENSETR \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $87C constant RCC_RCC_MP_AHB5LPENCLRR \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $880 constant RCC_RCC_MP_AHB6LPENSETR \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $884 constant RCC_RCC_MP_AHB6LPENCLRR \ This register may be separately and securely write-protected at a field level.
  $888 constant RCC_RCC_MP_S_AHB6LPENSETR    \ This is a secure register for enabling the clock of the MDMA in Sleep mode when it is used as secure. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $88C constant RCC_RCC_MP_S_AHB6LPENCLRR    \ This is a secure register for disabling the clock of the MDMA in Sleep mode when it is not used as secure. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $890 constant RCC_RCC_MP_NS_AHB6LPENSETR    \ This is a non-secure register for enabling the clock of the MDMA in Sleep mode when it is not used as secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $894 constant RCC_RCC_MP_NS_AHB6LPENCLRR    \ This is a non-secure register for disabling the clock of the MDMA in Sleep mode when it is not used as secure. This register is used in order to clear the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '0'.
  $898 constant RCC_RCC_MP_S_AXIMLPENSETR    \ This is a secure register, for enabling the clock of the SYSRAM during CSleep mode. A write access to this register field must be secure. A read access may be secure or non-secure. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $89C constant RCC_RCC_MP_S_AXIMLPENCLRR    \ This is a secure register, for disabling the clock of the SYSRAM during CSleep mode.
  $8A0 constant RCC_RCC_MP_NS_AXIMLPENSETR    \ This is a non-secure register, for enabling the clock of the SYSRAM during CSleep mode. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $8A4 constant RCC_RCC_MP_NS_AXIMLPENCLRR    \ This is a non-secure register, for disabling the clock of the SYSRAM during CSleep mode.
  $8A8 constant RCC_RCC_MP_MLAHBLPENSETR    \ This register may be separately and securely write-protected at a field level, as detailed in the following register fields description. This register is used in order to set the PERxLPEN bit of the corresponding peripheral. Writing '0' has no effect, reading will return the effective values of the corresponding bits. Writing a '1' sets the corresponding bit to '1'.
  $8AC constant RCC_RCC_MP_MLAHBLPENCLRR    \ This register may be separately and securely write-protected at a field level
  $8C0 constant RCC_RCC_APB3SECSR       \ This read register reflects at a bit level the secure state of each APB3 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  $8C4 constant RCC_RCC_APB4SECSR       \ This read register reflects at a bit level the secure state of each APB4 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  $8C8 constant RCC_RCC_APB5SECSR       \ This read register reflects at a bit level the secure state of each APB5 secure or securable peripheral, as configured either via the corresponding DECPROT[1] field of the ETZPC register or via the TrustZone-aware peripheral itself.
  $8CC constant RCC_RCC_APB6SECSR       \ This read register reflects at a bit level the secure state of each APB6 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  $8D0 constant RCC_RCC_AHB2SECSR       \ This read register reflects at a bit level the secure state of each AHB2 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  $8D4 constant RCC_RCC_AHB4SECSR       \ This read register reflects at a bit level the secure state of each AHB4 securable peripheral, as configured either via the corresponding DECPROT[1] field of the ETZPC register or via the TrustZone-aware peripheral itself.
  $8D8 constant RCC_RCC_AHB5SECSR       \ This read register reflects at a bit level the secure state of each AHB5 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  $8DC constant RCC_RCC_AHB6SECSR       \ This read register reflects at a bit level the secure state of each AHB6 securable peripheral, as configured via the corresponding DECPROT[1] field of the ETZPC register.
  $FF4 constant RCC_RCC_VERR            \ This register gives the IP version
  $FF8 constant RCC_RCC_IDR             \ This register gives the unique identifier of the RCC
  $FFC constant RCC_RCC_SIDR            \ This register gives the decoding space, which is for the RCC of 4 kB.

: RCC_DEF ; [then]
